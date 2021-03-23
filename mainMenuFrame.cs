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
using SautinSoft.Document;
using Color = SautinSoft.Document.Color;

namespace QuackyDocsV2Desktop
{
    public partial class mainMenuFrame : Form
    {
        textEditorFrame textEditor = new textEditorFrame(filename);
        public static String filename;

        public mainMenuFrame()
        {
            InitializeComponent();
            
        }

        private void createFileBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "rtf files (*.rtf)|";
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    
                    
                    myStream.Close();

                    // Set a path to our rtf file.
                    string rtfPath = saveFileDialog.FileName;

                    // Let's create a simple Rtf document.
                    DocumentCore dc = new DocumentCore();

                    // Save Rtf to a file
                    dc.Save(rtfPath, new RtfSaveOptions());

                    Form frm = new textEditorFrame(saveFileDialog.FileName);
                    frm.Show();
                    textEditor.Height = this.Height;
                    textEditor.Width = this.Width;
                    textEditor.Location = this.Location;

                    
                    this.Hide();
                }
            }
        }
        
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files (*.rtf)|*.rtf|TXT Files(*.txt)|*.txt";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.                
                textEditor.Height = this.Height;
                textEditor.Width = this.Width;
                textEditor.Location = this.Location;
                filename = Path.GetFileNameWithoutExtension(textEditor.file);

                Form frm = new textEditorFrame(openFile1.FileName);
                frm.Show();

                this.Hide();
            }
        }

        public static void setFilename(String LoginName)
        {
            mainMenuFrame.filename = LoginName;
        }

        public static String getFileName()
        {
            Console.WriteLine(filename);
            return filename;
            
        }

        
    }
}
