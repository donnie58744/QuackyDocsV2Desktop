using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace QuackyDocsV2Desktop
{
    public partial class textEditorFrame : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        public int fileMenuState = 0;
        public textEditorFrame()
        {
            InitializeComponent();
        }

        private void fileMenuBtn_Click(object sender, EventArgs e)
        {

            fileMenuState++;
            if (fileMenuState == 1)
            {
                fileMenu.Visible = true;
            }

            else if (fileMenuState == 2)
            {
                fileMenu.Visible = false;
                fileMenuState = 0;
            }

        }

        private void textArea_Click(object sender, EventArgs e)
        {
            fileMenuState = 2;

            if (fileMenuState == 2)
            {
                fileMenu.Visible = false;
                fileMenuState = 0;
            }
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\leath\source\repos\WindowsFormsApp1\WindowsFormsApp1\user\test.txt"))
            {
                writer.WriteLine(textArea.Text);
            }
        }

        private void fontDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(fontDropDown.SelectedItem);
            if (fontDropDown.SelectedItem == "Source Code Pro")
            {
                // Change the textArea font twice for auto refrshing
                for (int i = 0; i < 3; i++)
                {
                    textArea.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                }
            }

            else
            {
                textArea.SelectionFont = new Font(fontDropDown.Text, 12, FontStyle.Regular); ;
            }
        }

        private void fontSizeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Int32.Parse(fontSizeDropDown.Text);
            textArea.SelectionFont = new Font(textArea.Font.FontFamily, size, FontStyle.Regular);
        }

        private void fontColorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml(fontColorDropDown.Text);
            textArea.ForeColor = col;
        }

        private void textEditorFrame_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile(@"C:\xampp\htdocs\QuackyDocsV2\fonts\SourceCodePro-Medium.ttf");
            fontDropDown.SelectedIndex = 0;

            Console.WriteLine(textArea.Font.Size);

            fontSizeDropDown.SelectedItem = textArea.Font.Size.ToString();
        }
    }
}
