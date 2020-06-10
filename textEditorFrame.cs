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
using SautinSoft.Document;
using Color = SautinSoft.Document.Color;

namespace QuackyDocsV2Desktop
{
    public partial class textEditorFrame : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        public int fileMenuState = 0;
        public String file = null;
        public String fileName = null;
        public String fileWithoutExt = null;

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

        private void fontDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int size = Int32.Parse(fontSizeDropDown.Text);
                Console.WriteLine(fontDropDown.SelectedItem);
                if (fontDropDown.SelectedItem == "Source Code Pro Medium")
                {
                    // Change the textArea font twice for auto refrshing
                    for (int i = 0; i < 3; i++)
                    {
                        textArea.Font = new Font(pfc.Families[0], size, FontStyle.Regular);
                    }
                }

                else
                {
                    textArea.Font = new Font(fontDropDown.Text, size, FontStyle.Regular);
                    Console.WriteLine(textArea.SelectionFont);
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Font Invailed");
            }

        }

        private void fontSizeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = Int32.Parse(fontSizeDropDown.Text);
            if (fontDropDown.SelectedItem == "Source Code Pro Medium")
            {
                Console.WriteLine("SOURCE");
                for (int i = 0; i < 3; i++)
                {
                    textArea.Font = new Font(pfc.Families[0], size, FontStyle.Regular);
                }
            }
            else
            {
                textArea.SelectionFont = new Font(fontDropDown.Text, size, FontStyle.Regular);
            }
        }

        private void fontColorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml(fontColorDropDown.Text);
            textArea.ForeColor = col;
        }

        private void textEditorFrame_Load(object sender, EventArgs e)
        {
            pfc.AddFontFile(@"C:\xampp\htdocs\QuackyDocsV2\fonts\SourceCodePro-Medium.ttf");


            textArea.LoadFile(file);
            String convert = file;
            
            fileNameBox.Text = fileName;

            String size = textArea.SelectionFont.Size.ToString();
            String font = textArea.SelectionFont.Name;
            String color = textArea.SelectionColor.Name;
            fontSizeDropDown.SelectedItem = size;
            Console.WriteLine(fontDropDown.SelectedText);
            fontColorDropDown.SelectedItem = color;

            if (fontDropDown.SelectedItem == null)
            {
                fontDropDown.SelectedIndex = 3;
            }

            fontDropDown.SelectedItem = font;
        }

        private void textArea_KeyUp(object sender, KeyEventArgs e)
        {
            save();
        }

        private void openFileBtn_MouseHover(object sender, EventArgs e)
        {
            openFileBtn.BackColor = System.Drawing.Color.Gray;
        }

        private void openFileBtn_MouseLeave(object sender, EventArgs e)
        {
            openFileBtn.BackColor = System.Drawing.Color.Black;
        }

        private async void save()
        {
            textArea.SaveFile(file, RichTextBoxStreamType.RichText);
            savedLabel.Visible = true;
            savedLabel.Text = "Saving...";
            await Task.Delay(1000);
            savedLabel.Text = "Saved";


        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                file = openFile1.FileName;
                fileName = openFile1.SafeFileName;

                textArea.LoadFile(openFile1.FileName);
                fileNameBox.Text = fileName;

                String size = textArea.SelectionFont.Size.ToString();
                String font = textArea.SelectionFont.Name;
                String color = textArea.SelectionColor.Name;
                Console.WriteLine(textArea.SelectionColor.Name);
                fontSizeDropDown.SelectedItem = size;
                fontDropDown.SelectedItem = font;
                fontColorDropDown.SelectedItem = color;

                fileMenu.Visible = false;
                
            }
        }

        private void textEditorFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void duckBtn_Click(object sender, EventArgs e)
        {
            textArea.SaveFile(file, RichTextBoxStreamType.RichText);

            this.Hide();
            var mainMenu = new mainMenuFrame();
            mainMenu.Closed += (s, args) => this.Close();
            mainMenu.Show();
            mainMenu.Height = this.Height;
            mainMenu.Width = this.Width;
            mainMenu.Location = this.Location;
        }

        private void textArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save();
                Console.WriteLine("Save");
            }
        }

        private void topToolBar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save();
                Console.WriteLine("Save");
            }
        }

        private void divider_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save();
                Console.WriteLine("Save");
            }
        }

        private void bottomToolBar_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save();
                Console.WriteLine("Save");
            }
        }

        private void fileNameBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                save();
                Console.WriteLine("Save");
            }
        }
    }
}