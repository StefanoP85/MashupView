using System;
using System.IO;
using System.Text;
using System.Xml;

namespace MashupView
{
    class TQueryDefinitionFileFormat: Object
    {
        // Unsigned integer that MUST be set to 0.
        private UInt32 FVersion = 0;
        // Unsigned integer that specifies the length of the Package Parts field.
        private UInt32 FPackagePartsLength = 0;
        // Variable-length binary stream.
        private byte[] FPackageParts = null;
        // Unsigned integer that specifies the length of the Permissions field.
        private UInt32 FPermissionsLength = 0;
        // Variable-length binary stream.
        private byte[] FPermissions = null;
        // Unsigned integer that specifies the length of the Metadata field.
        private UInt32 FMetadataLength = 0;
        // Variable-length binary stream.
        private byte[] FMetadata = null;
        // Unsigned integer that specifies the length of the Permission Bindings field.
        private UInt32 FPermissionBindingsLength = 0;
        // Variable-length binary stream.
        private byte[] FPermissionBindings = null;
        public UInt32 Version { get => FVersion; }
        public UInt32 PackagePartsLength { get => FPackagePartsLength; }
        public byte[] PackageParts { get => FPackageParts; }
        public UInt32 PermissionsLength { get => FPermissionsLength; }
        public byte[] Permissions { get => FPermissions; }
        public UInt32 MetadataLength { get => FMetadataLength; }
        public byte[] Metadata { get => FMetadata; }
        public UInt32 PermissionBindingsLength { get => FPermissionBindingsLength; }
        public byte[] PermissionBindings { get => FPermissionBindings; }
        public TQueryDefinitionFileFormat(): base() { }
        public bool Load(in Stream Source)
        {
            if (Source == null)
                throw new NullReferenceException("TQueryDefinitionFileFormat::Load: null reference of the source stream.");
            else
            {
                using (BinaryReader SourceReader = new BinaryReader(Source))
                {
                    FVersion = SourceReader.ReadUInt32();
                    if (FVersion == 0)
                    {
                        FPackagePartsLength = SourceReader.ReadUInt32();
                        FPackageParts = SourceReader.ReadBytes((int)FPackagePartsLength);
                        FPermissionsLength = SourceReader.ReadUInt32();
                        FPermissions = SourceReader.ReadBytes((int)FPermissionsLength);
                        FMetadataLength = SourceReader.ReadUInt32();
                        FMetadata = SourceReader.ReadBytes((int)FMetadataLength);
                        FPermissionBindingsLength = SourceReader.ReadUInt32();
                        FPermissionBindings = SourceReader.ReadBytes((int)FPermissionBindingsLength);
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public MemoryStream GetPackageParts()
        {
            if (FPackagePartsLength > 0)
                return new MemoryStream(FPackageParts, false);
            else
                return null;
        }
        public XmlDocument GetMetadata()
        {
            if (FMetadataLength > 0)
            {
                using (MemoryStream MetadataStream = new MemoryStream(FMetadata, false))
                {
                    using (BinaryReader MetadataStreamReader = new BinaryReader(MetadataStream))
                    {
                        UInt32 MetadataVersion = MetadataStreamReader.ReadUInt32();
                        if (MetadataVersion == 0)
                        {
                            int MetadataXmlLength = MetadataStreamReader.ReadInt32();
                            byte[] MetadataXml = MetadataStreamReader.ReadBytes(MetadataXmlLength);
                            using (MemoryStream MetadataXmlStream = new MemoryStream(MetadataXml, false))
                            {
                                XmlDocument Result = new XmlDocument();
                                Result.Load(MetadataXmlStream);
                                return Result;
                            }
                        }
                        else
                            return null;
                    }
                }
            }
            else
                return null;
        }
    }
}
