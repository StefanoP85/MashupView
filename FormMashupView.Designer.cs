namespace MashupView
{
    partial class TFormMashupView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.TextBoxFileName = new System.Windows.Forms.TextBox();
            this.ListBoxQueries = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileSaveAllQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExportThisQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExportAllQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanelMain.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 2;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.Controls.Add(this.ButtonOpen, 0, 0);
            this.TableLayoutPanelMain.Controls.Add(this.TextBoxCode, 1, 1);
            this.TableLayoutPanelMain.Controls.Add(this.TextBoxFileName, 1, 0);
            this.TableLayoutPanelMain.Controls.Add(this.ListBoxQueries, 0, 1);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 28);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 2;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(782, 525);
            this.TableLayoutPanelMain.TabIndex = 2;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOpen.Location = new System.Drawing.Point(3, 3);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(250, 26);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Open...";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.AcceptsReturn = true;
            this.TextBoxCode.AcceptsTab = true;
            this.TextBoxCode.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCode.Font = new System.Drawing.Font("Consolas", 10F);
            this.TextBoxCode.Location = new System.Drawing.Point(259, 35);
            this.TextBoxCode.Multiline = true;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxCode.Size = new System.Drawing.Size(520, 487);
            this.TextBoxCode.TabIndex = 4;
            this.TextBoxCode.WordWrap = false;
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxFileName.Location = new System.Drawing.Point(259, 3);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(520, 22);
            this.TextBoxFileName.TabIndex = 2;
            // 
            // ListBoxQueries
            // 
            this.ListBoxQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListBoxQueries.FormattingEnabled = true;
            this.ListBoxQueries.HorizontalScrollbar = true;
            this.ListBoxQueries.ItemHeight = 20;
            this.ListBoxQueries.Location = new System.Drawing.Point(3, 35);
            this.ListBoxQueries.Name = "ListBoxQueries";
            this.ListBoxQueries.Size = new System.Drawing.Size(250, 487);
            this.ListBoxQueries.TabIndex = 3;
            this.ListBoxQueries.SelectedIndexChanged += new System.EventHandler(this.ListBoxQueries_SelectedIndexChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemView,
            this.ToolStripMenuItemHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(782, 28);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileOpen,
            this.ToolStripMenuItemFileSaveAllQueries,
            this.ToolStripMenuItemFileExportThisQuery,
            this.ToolStripMenuItemFileExportAllQueries,
            this.ToolStripMenuItemFileExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(46, 24);
            this.ToolStripMenuItemFile.Text = "File";
            // 
            // ToolStripMenuItemFileOpen
            // 
            this.ToolStripMenuItemFileOpen.Name = "ToolStripMenuItemFileOpen";
            this.ToolStripMenuItemFileOpen.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemFileOpen.Text = "Open...";
            this.ToolStripMenuItemFileOpen.Click += new System.EventHandler(this.ToolStripMenuItemFileOpen_Click);
            // 
            // ToolStripMenuItemFileSaveAllQueries
            // 
            this.ToolStripMenuItemFileSaveAllQueries.Enabled = false;
            this.ToolStripMenuItemFileSaveAllQueries.Name = "ToolStripMenuItemFileSaveAllQueries";
            this.ToolStripMenuItemFileSaveAllQueries.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemFileSaveAllQueries.Text = "Save all queries...";
            this.ToolStripMenuItemFileSaveAllQueries.Click += new System.EventHandler(this.ToolStripMenuItemFileSaveAllQueries_Click);
            // 
            // ToolStripMenuItemFileExportThisQuery
            // 
            this.ToolStripMenuItemFileExportThisQuery.Enabled = false;
            this.ToolStripMenuItemFileExportThisQuery.Name = "ToolStripMenuItemFileExportThisQuery";
            this.ToolStripMenuItemFileExportThisQuery.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemFileExportThisQuery.Text = "Export this query";
            this.ToolStripMenuItemFileExportThisQuery.Click += new System.EventHandler(this.ToolStripMenuItemFileExportThisQuery_Click);
            // 
            // ToolStripMenuItemFileExportAllQueries
            // 
            this.ToolStripMenuItemFileExportAllQueries.Enabled = false;
            this.ToolStripMenuItemFileExportAllQueries.Name = "ToolStripMenuItemFileExportAllQueries";
            this.ToolStripMenuItemFileExportAllQueries.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemFileExportAllQueries.Text = "Export all queries";
            this.ToolStripMenuItemFileExportAllQueries.Click += new System.EventHandler(this.ToolStripMenuItemFileExportAllQueries_Click);
            // 
            // ToolStripMenuItemFileExit
            // 
            this.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit";
            this.ToolStripMenuItemFileExit.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemFileExit.Text = "Exit";
            this.ToolStripMenuItemFileExit.Click += new System.EventHandler(this.ToolStripMenuItemFileExit_Click);
            // 
            // ToolStripMenuItemView
            // 
            this.ToolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemViewSettings});
            this.ToolStripMenuItemView.Name = "ToolStripMenuItemView";
            this.ToolStripMenuItemView.Size = new System.Drawing.Size(55, 24);
            this.ToolStripMenuItemView.Text = "View";
            // 
            // ToolStripMenuItemViewSettings
            // 
            this.ToolStripMenuItemViewSettings.Name = "ToolStripMenuItemViewSettings";
            this.ToolStripMenuItemViewSettings.Size = new System.Drawing.Size(154, 26);
            this.ToolStripMenuItemViewSettings.Text = "Settings...";
            this.ToolStripMenuItemViewSettings.Click += new System.EventHandler(this.ToolStripMenuItemViewSettings_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemHelpAbout});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(55, 24);
            this.ToolStripMenuItemHelp.Text = "Help";
            // 
            // ToolStripMenuItemHelpAbout
            // 
            this.ToolStripMenuItemHelpAbout.Name = "ToolStripMenuItemHelpAbout";
            this.ToolStripMenuItemHelpAbout.Size = new System.Drawing.Size(139, 26);
            this.ToolStripMenuItemHelpAbout.Text = "About..";
            this.ToolStripMenuItemHelpAbout.Click += new System.EventHandler(this.ToolStripMenuItemHelpAbout_Click);
            // 
            // TFormMashupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.TableLayoutPanelMain);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TFormMashupView";
            this.Text = "Mashup View";
            this.Load += new System.EventHandler(this.TFormMashupView_Load);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.TableLayoutPanelMain.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.TextBox TextBoxFileName;
        private System.Windows.Forms.ListBox ListBoxQueries;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileSaveAllQueries;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExportThisQuery;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExportAllQueries;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewSettings;
    }
}

