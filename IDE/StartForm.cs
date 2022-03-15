using System;
using System.IO;
using System.Windows.Forms;

namespace IDE
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "settings.json")))
            {
                StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "settings.json"));
                sw.Write("{ \"fontcolor\": \"0xFFD0D0D0\", \"bgcolor\": \"0xFF171717\", \"pnlcolor\": \"0xFF282828\", \"fontsize\": \"8,25\", \"fontstyle\": \"Cascadia Code\", \"fontins\": \"\" }");
                sw.Close();
            }
            InitializeComponent();
            Colorize.Customize(this);
            this.button1.Margin = new Padding();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select working directory";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                IDEForm IDE = new IDEForm(fbd.SelectedPath);
                IDE.Show();

            }
        }
    }
}
