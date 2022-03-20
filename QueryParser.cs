using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Text.RegularExpressions;
using System.Xml;

namespace MashupView
{
    class TQueryParser: Object
    {
        private string FVersion = null;
        private string FMinVersion = null;
        private string FCulture = null;
        private string FQueryMashup = null;
        private Dictionary<String, String> FQueryList;
        public string Version { get => FVersion;  }
        public string MinVersion { get => FMinVersion; }
        public string Culture { get => FCulture; }
        public string QueryMashup { get => FQueryMashup;  }
        public Dictionary<String, String> QueryList { get => FQueryList; }
        public TQueryParser(): base()
        {
            FQueryList = new Dictionary<String, String>();
        }
        public void Clear()
        {
            FVersion = null;
            FMinVersion = null;
            FCulture = null;
            FQueryMashup = null;
            FQueryList.Clear();
        }
        public void ReadPackage(in Stream Source)
        {
            if (Source != null)
            {
                XmlDocument SourceDOM = new XmlDocument();
                SourceDOM.Load(Source);
                FVersion = SourceDOM.SelectSingleNode("//Package/Version").InnerText;
                FMinVersion = SourceDOM.SelectSingleNode("//Package/MinVersion").InnerText;
                FCulture = SourceDOM.SelectSingleNode("//Package/Culture").InnerText;
            }
        }
        public void ReadQuery(in Stream Source)
        {
            if (Source == null)
                throw new ArgumentNullException("TQueryParser::ReadPackage: null reference of the source stream.");
            else
            {
                using (StreamReader SourceStream = new StreamReader(Source))
                {
                    FQueryMashup = SourceStream.ReadToEnd();
                    string[] QueryDefinitions = Regex.Split(FQueryMashup, ";(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                    for (int I = 0; I < QueryDefinitions.Length; I++)
                    {
                        string[] QueryParts = Regex.Split(QueryDefinitions[I], "(.*)shared(.+?) = (.*)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                        if (QueryParts.Length > 1)
                            FQueryList.Add(QueryParts[2].Trim(), QueryParts[3].Replace("\n", Environment.NewLine).Trim());
                    }
                }
            }
        }
        public bool ReadFile(in string FileSpec)
        {
            const string SearchXsdNamespace = "http://schemas.microsoft.com/DataMashup";
            const string SearchZipDirectory = "/customXml/";
            const string SearchZipExtension = ".xml";
            const string QueryPackageName = "/Config/Package.xml";
            const string QueryDirectory = "/Formulas/";
            Clear();
            using (FileStream ZipFileStream = new FileStream(FileSpec, FileMode.Open, FileAccess.Read))
            {
                using (Package ZipFilePackage = Package.Open(ZipFileStream))
                {
                    foreach (PackagePart ZipEntry in ZipFilePackage.GetParts())
                    {
                        string ZipEntryFilePath = ZipEntry.Uri.ToString();
                        if (ZipEntryFilePath.StartsWith(SearchZipDirectory, StringComparison.InvariantCultureIgnoreCase) && ZipEntryFilePath.EndsWith(SearchZipExtension, StringComparison.InvariantCultureIgnoreCase))
                        {
                            using (Stream ZipEntryStream = ZipEntry.GetStream(FileMode.Open, FileAccess.Read))
                            {
                                XmlDocument ZipEntryDOM = new XmlDocument();
                                ZipEntryDOM.Load(ZipEntryStream);
                                if (ZipEntryDOM.DocumentElement.NamespaceURI == SearchXsdNamespace)
                                {
                                    string BlobBase64 = ZipEntryDOM.DocumentElement.FirstChild.Value;
                                    using (MemoryStream DecodedBlob = new MemoryStream(Convert.FromBase64String(BlobBase64)))
                                    {
                                        TQueryDefinitionFileFormat QueryDefinitionFileFormat = new TQueryDefinitionFileFormat();
                                        if (QueryDefinitionFileFormat.Load(DecodedBlob))
                                        {
                                            Package QueryPackage = Package.Open(QueryDefinitionFileFormat.GetPackageParts());
                                            foreach (PackagePart QueryPackageEntry in QueryPackage.GetParts())
                                            {
                                                string QueryPackageEntryFilePath = QueryPackageEntry.Uri.ToString();
                                                if (QueryPackageEntryFilePath.Equals(QueryPackageName, StringComparison.InvariantCultureIgnoreCase))
                                                    using (Stream QueryPackageEntryStream = QueryPackageEntry.GetStream(FileMode.Open, FileAccess.Read))
                                                        ReadPackage(QueryPackageEntryStream);
                                                if (QueryPackageEntryFilePath.StartsWith(QueryDirectory, StringComparison.InvariantCultureIgnoreCase))
                                                    using (Stream QueryPackageEntryStream = QueryPackageEntry.GetStream(FileMode.Open, FileAccess.Read))
                                                        ReadQuery(QueryPackageEntryStream);
                                            }
                                        }
                                    }
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
