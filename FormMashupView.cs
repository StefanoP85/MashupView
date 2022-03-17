using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MashupView
{
    public partial class TFormMashupView : Form
    {
        private TFormAbout FormAbout = null;
        private TFormSettings FormSettings = null;
        private TQueryParser QueryParser = null;
        public TFormMashupView() : base()
        {
            InitializeComponent();
            FormAbout = new TFormAbout();
            FormSettings = new TFormSettings();
            QueryParser = new TQueryParser();
        }
        void ActionUpdate()
        {
            ListBoxQueries.Items.Clear();
            TextBoxCode.Text = "";
            if (QueryParser.QueryList.Count > 0)
            {
                foreach (String QueryName in QueryParser.QueryList.Keys)
                    ListBoxQueries.Items.Add(QueryName);
                ToolStripMenuItemFileExportAllQueries.Enabled = true;
                ToolStripMenuItemFileExportThisQuery.Enabled = true; 
                ToolStripMenuItemFileSaveAllQueries.Enabled = true;
            }
            else
            {
                ToolStripMenuItemFileExportAllQueries.Enabled = false;
                ToolStripMenuItemFileExportThisQuery.Enabled = false;
                ToolStripMenuItemFileSaveAllQueries.Enabled = false;
            }
        }
        void ActionOpen()
        {
            using (OpenFileDialog ExcelOpenFileDialog = new OpenFileDialog())
            {
                ExcelOpenFileDialog.Filter = "Excel files (*.xlsb;*.xlsm;*.xlsx)|*.xlsb;*.xlsm;*.xlsx";
                ExcelOpenFileDialog.FilterIndex = 1;
                ExcelOpenFileDialog.RestoreDirectory = true;
                if (ExcelOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string FileSpec = ExcelOpenFileDialog.FileName;
                    try
                    {
                        if (QueryParser.ReadFile(FileSpec))
                            TextBoxFileName.Text = FileSpec;
                        else
                            TextBoxFileName.Text = "";
                    }
                    catch (IOException E)
                    {
                        MessageBox.Show("An error has occured reading the selected file.\r\n\r\n" + E.Message);
                    }
                    ActionUpdate();
                }
            }
        }
        private void ButtonOpen_Click(object Sender, EventArgs E)
        {
            ActionOpen();
        }
        private void ListBoxQueries_SelectedIndexChanged(object Sender, EventArgs E)
        {
            if (ListBoxQueries.SelectedIndex >= 0)
            {
                string QueryName = (string)ListBoxQueries.SelectedItem;
                TextBoxCode.Text = QueryParser.QueryList[QueryName];
            }
        }
        private void TFormMashupView_Load(object Sender, EventArgs E)
        {
            FormSettings.InitSettings(TextBoxCode.Font, TextBoxCode.ForeColor, TextBoxCode.BackColor, ListBoxQueries.Font, ListBoxQueries.ForeColor, ListBoxQueries.BackColor);
        }
        private void ToolStripMenuItemFileOpen_Click(object Sender, EventArgs E)
        {
            ActionOpen();
        }
        private void ToolStripMenuItemFileExit_Click(object Sender, EventArgs E)
        {
            Application.Exit();
        }
        private void ToolStripMenuItemFileExportAllQueries_Click(object Sender, EventArgs E)
        {
            Clipboard.SetText(QueryParser.QueryMashup);
        }
        private void ToolStripMenuItemFileExportThisQuery_Click(object Sender, EventArgs E)
        {
            Clipboard.SetText(TextBoxCode.Text);
        }
        private void ToolStripMenuItemFileSaveAllQueries_Click(object Sender, EventArgs E)
        {
            using (SaveFileDialog ExcelSaveFileDialog = new SaveFileDialog())
            {
                ExcelSaveFileDialog.Filter = "Text files (*.txt)|*.txt|Any files (*.*)|*.*";
                ExcelSaveFileDialog.FilterIndex = 1;
                ExcelSaveFileDialog.RestoreDirectory = true;
                if (ExcelSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string FileSpec = ExcelSaveFileDialog.FileName;
                    using (FileStream SaveFileStream = new FileStream(FileSpec, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        using (StreamWriter SaveFileStreamWriter = new StreamWriter(SaveFileStream))
                        {
                            SaveFileStreamWriter.Write(QueryParser.QueryMashup);
                            SaveFileStreamWriter.Flush();
                        }
                    }
                }
            }
        }
        private void ToolStripMenuItemHelpAbout_Click(object Sender, EventArgs E)
        {
            FormAbout.Show();
        }
        private void ToolStripMenuItemViewSettings_Click(object Sender, EventArgs E)
        {
            Font AppFont;
            Color AppColor;
            Color AppBackgroundColor;
            Font CodeFont;
            Color CodeColor;
            Color CodeBackgroundColor;
            FormSettings.ShowDialog();
            FormSettings.GetSettings(out CodeFont, out CodeColor, out CodeBackgroundColor, out AppFont, out AppColor, out AppBackgroundColor);
            TextBoxCode.Font = CodeFont;
            TextBoxCode.ForeColor = CodeColor;
            TextBoxCode.BackColor = CodeBackgroundColor;
            ListBoxQueries.Font = AppFont;
            ListBoxQueries.ForeColor = AppColor;
            ListBoxQueries.BackColor = AppBackgroundColor;
        }
    }
}
