using System;
using System.IO;
using System.Windows.Forms;

namespace IDE
{
    public partial class IDEForm : Form
    {
        public string IDEPath;
        public IDEForm(string path)
        {
            InitializeComponent();
            this.KeyPreview = true;
            Colorize.Customize(this);
            IDEPath = path;
            newTabToolStripMenuItem_Click(null, null);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                treeView1.NodeMouseDoubleClick += treeView_DoubleClick;
                BuildTree(directoryInfo, treeView1.Nodes);
            }

        }
        private void IDE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) saveToolStripMenuItem_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.N) createToolStripMenuItem_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.O) openToolStripMenuItem_Click(null, null);
            else if (e.Shift && e.Control && e.KeyCode == Keys.O) changeWorkspaceToolStripMenuItem_Click(null, null);
        }
        private void treeView_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string filename = e.Node.Name;
            if (filename.Contains("."))
            {
                TabPage tPage = new TabPage(Path.GetFileName(filename));    // add tabbing?
                RichTextBox rText = new RichTextBox();
                rText.Dock = DockStyle.Fill;
                StreamReader reader = new StreamReader(filename);
                rText.Text = reader.ReadToEnd();
                reader.Close();
                tPage.Name = filename;
                rText.AcceptsTab = true;
                Colorize.ColorRT(rText);

                tPage.Controls.Add(rText);
                CodeTabControl.TabPages.Add(tPage);
                CodeTabControl.SelectedTab = tPage;
            }
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
                if (file.Name.Contains("."))
                {
                    curNode.Nodes[curNode.Nodes.Count - 1].ImageIndex = 0;
                    curNode.Nodes[curNode.Nodes.Count - 1].SelectedImageIndex = 0;
                }
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }
        private void IDEForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (TabPage tb in CMDTabControl.TabPages)
            {
                ConsoleControl.ConsoleControl cmd = (ConsoleControl.ConsoleControl)(object)tb.Controls[0];
                cmd.ProcessInterface.Dispose();
            }
            Application.Exit();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewFileDialog fd = new NewFileDialog())
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    TabPage tPage = new TabPage(fd.fileName);
                    RichTextBox rText = new RichTextBox();
                    rText.Dock = DockStyle.Fill;
                    rText.AcceptsTab = true;
                    Colorize.ColorRT(rText);
                    tPage.Name = "!";

                    tPage.Controls.Add(rText);
                    CodeTabControl.TabPages.Add(tPage);
                    CodeTabControl.SelectedTab = tPage;
                    CodeTabControl.Show();
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CodeTabControl.TabCount > 0)
            {
                if (CodeTabControl.SelectedTab.Name == "!")
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(sfd.FileName);
                            string text = CodeTabControl.SelectedTab.Controls[0].Text;
                            sw.Write(text);

                            CodeTabControl.SelectedTab.Name = sfd.FileName;
                            CodeTabControl.SelectedTab.Text = Path.GetFileName(sfd.FileName);

                            sw.Close();

                        }
                    }
                }
                else
                {
                    StreamWriter sw = new StreamWriter(CodeTabControl.SelectedTab.Name);
                    string text = CodeTabControl.SelectedTab.Controls[0].Text;
                    sw.Write(text);
                    sw.Close();
                }
                treeView1.Nodes.Clear();
                BuildTree(new DirectoryInfo(IDEPath), treeView1.Nodes);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text|*.txt|All|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TabPage tPage = new TabPage(Path.GetFileName(ofd.FileName));
                RichTextBox rText = new RichTextBox();
                rText.Dock = DockStyle.Fill;
                StreamReader reader = new StreamReader(ofd.FileName);
                rText.Text = reader.ReadToEnd();
                reader.Close();
                tPage.Name = ofd.FileName;
                rText.AcceptsTab = true;
                Colorize.ColorRT(rText);

                tPage.Controls.Add(rText);
                CodeTabControl.TabPages.Add(tPage);
                CodeTabControl.SelectedTab = tPage;
            }
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UISettingsForm UI = new UISettingsForm();
            UI.Show();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tPage = new TabPage("CMD" + (CMDTabControl.TabCount + 1).ToString());
            ConsoleControl.ConsoleControl cmd = new ConsoleControl.ConsoleControl(); ;
            cmd.Dock = DockStyle.Fill;
            cmd.StartProcess("cmd", $"\"\"\"/K cd /d {IDEPath}\"\"\"");
            tPage.Controls.Add(cmd);
            CMDTabControl.TabPages.Add(tPage);
            CMDTabControl.SelectedTab = tPage;
        }

        private void changeWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select working directory";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage tb in CMDTabControl.TabPages)
                {
                    ConsoleControl.ConsoleControl cmd = (ConsoleControl.ConsoleControl)(object)tb.Controls[0];
                    cmd.ProcessInterface.Dispose();
                }
                this.Dispose();
                IDEForm IDE = new IDEForm(fbd.SelectedPath);
                IDE.Show();
            }
        }
    }
}
