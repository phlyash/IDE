using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IDE
{
    public static class Colorize
    {
        public static Dictionary<string, string> settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "settings.json")));
        public static void Customize(Form form)
        {
            for (int i = 0; i < form.Controls.Count; i++)
            {
                form.Controls[i].BackColor = Color.FromArgb(Convert.ToInt32(settings["bgcolor"], 16));
                form.Controls[i].ForeColor = Color.FromArgb(Convert.ToInt32(settings["fontcolor"], 16));
                form.Controls[i].Font = SetFont();
                if (form.Controls[i].HasChildren) ColorBGPanels(form.Controls[i].Controls);
                else if (form.Controls[i] is MenuStrip)
                {
                    MenuStrip mS = (MenuStrip)form.Controls[i];
                    ColorBGPanels(mS.Items);
                }
            }
        }
        private static Font SetFont()
        {
            FontStyle fontStyle = new FontStyle();
            if (settings["fontins"].Contains("B")) fontStyle |= FontStyle.Bold;
            if (settings["fontins"].Contains("I")) fontStyle |= FontStyle.Italic;
            double size = Convert.ToDouble(settings["fontsize"]);
            return new Font(settings["fontstyle"], (float)size, fontStyle);

        }
        private static void ColorBGPanels(Control.ControlCollection collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i].BackColor = Color.FromArgb(Convert.ToInt32(settings["bgcolor"], 16));
                collection[i].ForeColor = Color.FromArgb(Convert.ToInt32(settings["fontcolor"], 16));
                if (!(collection[i] is Label)) collection[i].Font = SetFont();
                if (!collection[i].HasChildren && !(collection[i] is Label)) ColorPnlPanels(collection[i]);
                else ColorBGPanels(collection[i].Controls);
            }
        }
        private static void ColorBGPanels(ToolStripItemCollection collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                collection[i].BackColor = Color.FromArgb(Convert.ToInt32(settings["bgcolor"], 16));
                collection[i].ForeColor = Color.FromArgb(Convert.ToInt32(settings["fontcolor"], 16));
                collection[i].Font = SetFont();
                ToolStripMenuItem item = (ToolStripMenuItem)collection[i];
                if (item.HasDropDownItems) ColorBGPanels(item.DropDownItems);
            }
        }
        private static void ColorPnlPanels(Control collection)
        {
            collection.Font = SetFont();
            collection.BackColor = Color.FromArgb(Convert.ToInt32(settings["pnlcolor"], 16));
            collection.ForeColor = Color.FromArgb(Convert.ToInt32(settings["fontcolor"], 16));
        }
        public static void ColorRT(RichTextBox rText)
        {
            rText.Font = SetFont();
            rText.BackColor = Color.FromArgb(Convert.ToInt32(settings["pnlcolor"], 16));
            rText.ForeColor = Color.FromArgb(Convert.ToInt32(settings["fontcolor"], 16));
        }
    }
}
