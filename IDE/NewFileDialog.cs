using System.Windows.Forms;


namespace IDE
{
    public partial class NewFileDialog : Form
    {
        public string fileName { get; set; }
        public NewFileDialog()
        {
            InitializeComponent();
            Colorize.Customize(this);
            this.CenterToParent();
        }
        private void fileNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                fileName = fileNameTextBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (e.KeyChar == 27)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
