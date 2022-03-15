using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IDE
{
    public partial class UISettingsForm : Form
    {
        public Dictionary<string, string> settings = Colorize.settings;
        public UISettingsForm()
        {
            InitializeComponent();
            Colorize.Customize(this);
        }
        private string convertNum(int num)
        {
            switch (num)
            {
                case 15:
                    return "F";
                case 14:
                    return "E";
                case 13:
                    return "D";
                case 12:
                    return "C";
                case 11:
                    return "B";
                case 10:
                    return "A";
                default:
                    return num.ToString();

            }
        }
        private string ToHex(int color)
        {
            return convertNum(color / 16) + convertNum(color % 16);
        }
        private void BGCButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.BGCPanel.BackColor = cd.Color;
                    settings["bgcolor"] = "0xFF" + ToHex(cd.Color.R) + ToHex(cd.Color.G) + ToHex(cd.Color.B);
                }
            }
        }
        private void FCButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.FCPanel.BackColor = cd.Color;
                    settings["fontcolor"] = "0xFF" + ToHex(cd.Color.R) + ToHex(cd.Color.G) + ToHex(cd.Color.B);
                }
            }
        }
        private void FButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fd = new FontDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.FTextBox.Font = fd.Font;
                    settings["fontsize"] = fd.Font.Size.ToString();
                    settings["fontstyle"] = fd.Font.FontFamily.Name;
                    settings["fontins"] = "";
                    if (fd.Font.Italic) settings["fontins"] = "I";
                    if (fd.Font.Bold) settings["fontins"] += "B";
                }
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Restart restart = new Restart(settings);
            restart.Show();
        }
        private void PCButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    this.PCPanel.BackColor = cd.Color;
                    settings["pnlcolor"] = "0xFF" + ToHex(cd.Color.R) + ToHex(cd.Color.G) + ToHex(cd.Color.B);
                }
            }
        }
    }
}
