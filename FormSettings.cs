using System;
using System.Drawing;
using System.Windows.Forms;

namespace MashupView
{
    public partial class TFormSettings : Form
    {
        public TFormSettings() : base()
        {
            InitializeComponent();
        }
        private void UpdateControls()
        {
            TextBoxApp.Font = FontDialogApp.Font;
            TextBoxApp.ForeColor = FontDialogApp.Color;
            TextBoxApp.BackColor = ColorDialogApp.Color;
            TextBoxAppFont.Text = FontDialogApp.Font.FontFamily.Name + ", " + Convert.ToString(FontDialogApp.Font.Size);
            TextBoxCode.Font = FontDialogCode.Font;
            TextBoxCode.ForeColor = FontDialogCode.Color;
            TextBoxCode.BackColor = ColorDialogCode.Color;
            TextBoxCodeFont.Text = FontDialogCode.Font.FontFamily.Name + ", " + Convert.ToString(FontDialogCode.Font.Size);
        }
        public void InitSettings(in Font CodeFont, in Color CodeColor, in Color CodeBackgroundColor, in Font AppFont, in Color AppColor, in Color AppBackgroundColor)
        {
            FontDialogCode.Font = CodeFont;
            FontDialogCode.Color = CodeColor;
            ColorDialogCode.Color = CodeBackgroundColor;
            FontDialogApp.Font = AppFont;
            FontDialogApp.Color = AppColor;
            ColorDialogApp.Color = AppBackgroundColor;
            UpdateControls();
        }
        public void GetSettings(out Font CodeFont, out Color CodeColor, out Color CodeBackgroundColor, out Font AppFont, out Color AppColor, out Color AppBackgroundColor)
        {
            CodeFont = FontDialogCode.Font;
            CodeColor = FontDialogCode.Color;
            CodeBackgroundColor = ColorDialogCode.Color;
            AppFont = FontDialogApp.Font;
            AppColor = FontDialogApp.Color;
            AppBackgroundColor = ColorDialogApp.Color;
        }
        private void ButtonFontColor_Click(object sender, EventArgs e)
        {
            if (ColorDialogApp.ShowDialog() == DialogResult.OK)
            {
                UpdateControls();
            }
        }
        private void ButtonAppFont_Click(object sender, EventArgs e)
        {
            if (FontDialogApp.ShowDialog() == DialogResult.OK)
            {
                UpdateControls();
            }
        }
        private void ButtonCodeColor_Click(object Sender, EventArgs E)
        {
            if (ColorDialogCode.ShowDialog() == DialogResult.OK)
            {
                UpdateControls();
            }
        }
        private void ButtonCodeFont_Click(object Sender, EventArgs E)
        {
            if (FontDialogCode.ShowDialog() == DialogResult.OK)
            {
                UpdateControls();
            }
        }
        private void TFormSettings_FormClosing(object Sender, FormClosingEventArgs E)
        {
            E.Cancel = true;
            Hide();
        }
    }
}
