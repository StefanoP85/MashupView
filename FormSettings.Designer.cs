namespace MashupView
{
    partial class TFormSettings
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
            this.ColorDialogCode = new System.Windows.Forms.ColorDialog();
            this.ColorDialogApp = new System.Windows.Forms.ColorDialog();
            this.FontDialogCode = new System.Windows.Forms.FontDialog();
            this.GroupBoxCode = new System.Windows.Forms.GroupBox();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.GroupBoxApp = new System.Windows.Forms.GroupBox();
            this.TextBoxCodeFont = new System.Windows.Forms.TextBox();
            this.LabelCodeFont = new System.Windows.Forms.Label();
            this.ButtonCodeFont = new System.Windows.Forms.Button();
            this.ButtonCodeColor = new System.Windows.Forms.Button();
            this.FontDialogApp = new System.Windows.Forms.FontDialog();
            this.ButtonFontColor = new System.Windows.Forms.Button();
            this.ButtonAppFont = new System.Windows.Forms.Button();
            this.LabelAppFont = new System.Windows.Forms.Label();
            this.TextBoxAppFont = new System.Windows.Forms.TextBox();
            this.TextBoxApp = new System.Windows.Forms.TextBox();
            this.GroupBoxCode.SuspendLayout();
            this.GroupBoxApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorDialogCode
            // 
            this.ColorDialogCode.AnyColor = true;
            this.ColorDialogCode.FullOpen = true;
            // 
            // ColorDialogApp
            // 
            this.ColorDialogApp.AnyColor = true;
            this.ColorDialogApp.FullOpen = true;
            // 
            // FontDialogCode
            // 
            this.FontDialogCode.ShowApply = true;
            this.FontDialogCode.ShowColor = true;
            // 
            // GroupBoxCode
            // 
            this.GroupBoxCode.Controls.Add(this.ButtonCodeColor);
            this.GroupBoxCode.Controls.Add(this.ButtonCodeFont);
            this.GroupBoxCode.Controls.Add(this.LabelCodeFont);
            this.GroupBoxCode.Controls.Add(this.TextBoxCodeFont);
            this.GroupBoxCode.Controls.Add(this.TextBoxCode);
            this.GroupBoxCode.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCode.Name = "GroupBoxCode";
            this.GroupBoxCode.Size = new System.Drawing.Size(598, 189);
            this.GroupBoxCode.TabIndex = 0;
            this.GroupBoxCode.TabStop = false;
            this.GroupBoxCode.Text = "Code settings";
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.Location = new System.Drawing.Point(287, 21);
            this.TextBoxCode.Multiline = true;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.ReadOnly = true;
            this.TextBoxCode.Size = new System.Drawing.Size(305, 162);
            this.TextBoxCode.TabIndex = 0;
            this.TextBoxCode.Text = "Query_Example = let\r\n\tStatement 1... ,\r\n\tStatement 2... ,\r\n\tStatement 3... ,\r\n// " +
    "comment\r\nin\r\n\tResult";
            // 
            // GroupBoxApp
            // 
            this.GroupBoxApp.Controls.Add(this.ButtonFontColor);
            this.GroupBoxApp.Controls.Add(this.ButtonAppFont);
            this.GroupBoxApp.Controls.Add(this.LabelAppFont);
            this.GroupBoxApp.Controls.Add(this.TextBoxAppFont);
            this.GroupBoxApp.Controls.Add(this.TextBoxApp);
            this.GroupBoxApp.Location = new System.Drawing.Point(12, 221);
            this.GroupBoxApp.Name = "GroupBoxApp";
            this.GroupBoxApp.Size = new System.Drawing.Size(598, 189);
            this.GroupBoxApp.TabIndex = 1;
            this.GroupBoxApp.TabStop = false;
            this.GroupBoxApp.Text = "Application settings";
            // 
            // TextBoxCodeFont
            // 
            this.TextBoxCodeFont.Location = new System.Drawing.Point(6, 97);
            this.TextBoxCodeFont.Name = "TextBoxCodeFont";
            this.TextBoxCodeFont.ReadOnly = true;
            this.TextBoxCodeFont.Size = new System.Drawing.Size(275, 22);
            this.TextBoxCodeFont.TabIndex = 1;
            // 
            // LabelCodeFont
            // 
            this.LabelCodeFont.AutoSize = true;
            this.LabelCodeFont.Location = new System.Drawing.Point(6, 77);
            this.LabelCodeFont.Name = "LabelCodeFont";
            this.LabelCodeFont.Size = new System.Drawing.Size(80, 17);
            this.LabelCodeFont.TabIndex = 2;
            this.LabelCodeFont.Text = "Font family:";
            // 
            // ButtonCodeFont
            // 
            this.ButtonCodeFont.Location = new System.Drawing.Point(6, 21);
            this.ButtonCodeFont.Name = "ButtonCodeFont";
            this.ButtonCodeFont.Size = new System.Drawing.Size(275, 53);
            this.ButtonCodeFont.TabIndex = 0;
            this.ButtonCodeFont.Text = "Select font...";
            this.ButtonCodeFont.UseVisualStyleBackColor = true;
            this.ButtonCodeFont.Click += new System.EventHandler(this.ButtonCodeFont_Click);
            // 
            // ButtonCodeColor
            // 
            this.ButtonCodeColor.Location = new System.Drawing.Point(6, 130);
            this.ButtonCodeColor.Name = "ButtonCodeColor";
            this.ButtonCodeColor.Size = new System.Drawing.Size(275, 53);
            this.ButtonCodeColor.TabIndex = 3;
            this.ButtonCodeColor.Text = "Select background color...";
            this.ButtonCodeColor.UseVisualStyleBackColor = true;
            this.ButtonCodeColor.Click += new System.EventHandler(this.ButtonCodeColor_Click);
            // 
            // FontDialogApp
            // 
            this.FontDialogApp.ShowApply = true;
            this.FontDialogApp.ShowColor = true;
            // 
            // ButtonFontColor
            // 
            this.ButtonFontColor.Location = new System.Drawing.Point(6, 130);
            this.ButtonFontColor.Name = "ButtonFontColor";
            this.ButtonFontColor.Size = new System.Drawing.Size(275, 53);
            this.ButtonFontColor.TabIndex = 8;
            this.ButtonFontColor.Text = "Select background color...";
            this.ButtonFontColor.UseVisualStyleBackColor = true;
            this.ButtonFontColor.Click += new System.EventHandler(this.ButtonFontColor_Click);
            // 
            // ButtonAppFont
            // 
            this.ButtonAppFont.Location = new System.Drawing.Point(6, 21);
            this.ButtonAppFont.Name = "ButtonAppFont";
            this.ButtonAppFont.Size = new System.Drawing.Size(275, 53);
            this.ButtonAppFont.TabIndex = 4;
            this.ButtonAppFont.Text = "Select font...";
            this.ButtonAppFont.UseVisualStyleBackColor = true;
            this.ButtonAppFont.Click += new System.EventHandler(this.ButtonAppFont_Click);
            // 
            // LabelAppFont
            // 
            this.LabelAppFont.AutoSize = true;
            this.LabelAppFont.Location = new System.Drawing.Point(6, 77);
            this.LabelAppFont.Name = "LabelAppFont";
            this.LabelAppFont.Size = new System.Drawing.Size(80, 17);
            this.LabelAppFont.TabIndex = 7;
            this.LabelAppFont.Text = "Font family:";
            // 
            // TextBoxAppFont
            // 
            this.TextBoxAppFont.Location = new System.Drawing.Point(6, 97);
            this.TextBoxAppFont.Name = "TextBoxAppFont";
            this.TextBoxAppFont.ReadOnly = true;
            this.TextBoxAppFont.Size = new System.Drawing.Size(275, 22);
            this.TextBoxAppFont.TabIndex = 6;
            // 
            // TextBoxApp
            // 
            this.TextBoxApp.Location = new System.Drawing.Point(287, 21);
            this.TextBoxApp.Multiline = true;
            this.TextBoxApp.Name = "TextBoxApp";
            this.TextBoxApp.ReadOnly = true;
            this.TextBoxApp.Size = new System.Drawing.Size(305, 162);
            this.TextBoxApp.TabIndex = 5;
            this.TextBoxApp.Text = "Query 1\r\nQuery 2\r\nQuery 3\r\n...\r\nQuery N";
            // 
            // TFormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.GroupBoxApp);
            this.Controls.Add(this.GroupBoxCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "TFormSettings";
            this.Text = "FormSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TFormSettings_FormClosing);
            this.GroupBoxCode.ResumeLayout(false);
            this.GroupBoxCode.PerformLayout();
            this.GroupBoxApp.ResumeLayout(false);
            this.GroupBoxApp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog ColorDialogCode;
        private System.Windows.Forms.ColorDialog ColorDialogApp;
        private System.Windows.Forms.FontDialog FontDialogCode;
        private System.Windows.Forms.GroupBox GroupBoxCode;
        private System.Windows.Forms.TextBox TextBoxCode;
        private System.Windows.Forms.GroupBox GroupBoxApp;
        private System.Windows.Forms.Button ButtonCodeColor;
        private System.Windows.Forms.Button ButtonCodeFont;
        private System.Windows.Forms.Label LabelCodeFont;
        private System.Windows.Forms.TextBox TextBoxCodeFont;
        private System.Windows.Forms.Button ButtonFontColor;
        private System.Windows.Forms.Button ButtonAppFont;
        private System.Windows.Forms.Label LabelAppFont;
        private System.Windows.Forms.TextBox TextBoxAppFont;
        private System.Windows.Forms.TextBox TextBoxApp;
        private System.Windows.Forms.FontDialog FontDialogApp;
    }
}