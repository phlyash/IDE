using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IDE
{
    public partial class Restart : Form
    {
        public Dictionary<string, string> settings;
        public Restart(Dictionary<string, string> newsettings)
        {
            settings = newsettings;
            InitializeComponent();
            Colorize.Customize(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = File.CreateText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "settings.json")))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, settings);
            }
            Application.Restart();
            Environment.Exit(0);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
