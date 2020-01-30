namespace QuackyDocsV2Desktop
{
    partial class textEditorFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(textEditorFrame));
            this.topToolBar = new System.Windows.Forms.Panel();
            this.fileMenuBtn = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.duckBtn = new System.Windows.Forms.Button();
            this.fileMenu = new System.Windows.Forms.Panel();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.divider = new System.Windows.Forms.Panel();
            this.bottomToolBar = new System.Windows.Forms.Panel();
            this.fontColorDropDown = new System.Windows.Forms.ComboBox();
            this.fontSizeDropDown = new System.Windows.Forms.ComboBox();
            this.fontDropDown = new System.Windows.Forms.ComboBox();
            this.topToolBar.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.bottomToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topToolBar
            // 
            this.topToolBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.topToolBar.Controls.Add(this.fileMenuBtn);
            this.topToolBar.Controls.Add(this.fileNameBox);
            this.topToolBar.Controls.Add(this.duckBtn);
            this.topToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topToolBar.Location = new System.Drawing.Point(0, 0);
            this.topToolBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topToolBar.Name = "topToolBar";
            this.topToolBar.Size = new System.Drawing.Size(1275, 108);
            this.topToolBar.TabIndex = 1;
            // 
            // fileMenuBtn
            // 
            this.fileMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenuBtn.Location = new System.Drawing.Point(120, 60);
            this.fileMenuBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileMenuBtn.Name = "fileMenuBtn";
            this.fileMenuBtn.Size = new System.Drawing.Size(69, 34);
            this.fileMenuBtn.TabIndex = 1;
            this.fileMenuBtn.Text = "File";
            this.fileMenuBtn.UseVisualStyleBackColor = true;
            this.fileMenuBtn.Click += new System.EventHandler(this.fileMenuBtn_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.fileNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameBox.ForeColor = System.Drawing.Color.White;
            this.fileNameBox.Location = new System.Drawing.Point(120, 14);
            this.fileNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(297, 29);
            this.fileNameBox.TabIndex = 0;
            this.fileNameBox.WordWrap = false;
            // 
            // duckBtn
            // 
            this.duckBtn.BackgroundImage = global::QuackyDocsV2Desktop.Properties.Resources.DuckButton;
            this.duckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.duckBtn.Location = new System.Drawing.Point(12, 14);
            this.duckBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duckBtn.Name = "duckBtn";
            this.duckBtn.Size = new System.Drawing.Size(89, 81);
            this.duckBtn.TabIndex = 0;
            this.duckBtn.UseVisualStyleBackColor = true;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.fileMenu.Controls.Add(this.saveAsBtn);
            this.fileMenu.Controls.Add(this.openFileBtn);
            this.fileMenu.Location = new System.Drawing.Point(120, 95);
            this.fileMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(192, 265);
            this.fileMenu.TabIndex = 2;
            this.fileMenu.Visible = false;
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.FlatAppearance.BorderSize = 0;
            this.saveAsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsBtn.ForeColor = System.Drawing.Color.White;
            this.saveAsBtn.Location = new System.Drawing.Point(0, 96);
            this.saveAsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(192, 54);
            this.saveAsBtn.TabIndex = 1;
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.MouseLeave += new System.EventHandler(this.saveAsBtn_MouseLeave);
            this.saveAsBtn.MouseHover += new System.EventHandler(this.saveAsBtn_MouseHover);
            // 
            // openFileBtn
            // 
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Location = new System.Drawing.Point(0, 21);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(192, 54);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            this.openFileBtn.MouseLeave += new System.EventHandler(this.openFileBtn_MouseLeave);
            this.openFileBtn.MouseHover += new System.EventHandler(this.openFileBtn_MouseHover);
            // 
            // textArea
            // 
            this.textArea.AcceptsTab = true;
            this.textArea.BackColor = System.Drawing.Color.Silver;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(0, 183);
            this.textArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(1275, 430);
            this.textArea.TabIndex = 4;
            this.textArea.Text = "";
            this.textArea.Click += new System.EventHandler(this.textArea_Click);
            this.textArea.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textArea_KeyUp);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divider.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider.Location = new System.Drawing.Point(0, 108);
            this.divider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1275, 12);
            this.divider.TabIndex = 5;
            // 
            // bottomToolBar
            // 
            this.bottomToolBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.bottomToolBar.Controls.Add(this.fontColorDropDown);
            this.bottomToolBar.Controls.Add(this.fontSizeDropDown);
            this.bottomToolBar.Controls.Add(this.fontDropDown);
            this.bottomToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomToolBar.Location = new System.Drawing.Point(0, 120);
            this.bottomToolBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bottomToolBar.Name = "bottomToolBar";
            this.bottomToolBar.Size = new System.Drawing.Size(1275, 63);
            this.bottomToolBar.TabIndex = 6;
            // 
            // fontColorDropDown
            // 
            this.fontColorDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontColorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontColorDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorDropDown.FormattingEnabled = true;
            this.fontColorDropDown.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Orange",
            "Purple"});
            this.fontColorDropDown.Location = new System.Drawing.Point(704, 15);
            this.fontColorDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fontColorDropDown.Name = "fontColorDropDown";
            this.fontColorDropDown.Size = new System.Drawing.Size(160, 28);
            this.fontColorDropDown.TabIndex = 2;
            this.fontColorDropDown.SelectedIndexChanged += new System.EventHandler(this.fontColorDropDown_SelectedIndexChanged);
            // 
            // fontSizeDropDown
            // 
            this.fontSizeDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontSizeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeDropDown.FormattingEnabled = true;
            this.fontSizeDropDown.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.fontSizeDropDown.Location = new System.Drawing.Point(601, 15);
            this.fontSizeDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fontSizeDropDown.Name = "fontSizeDropDown";
            this.fontSizeDropDown.Size = new System.Drawing.Size(77, 28);
            this.fontSizeDropDown.TabIndex = 1;
            this.fontSizeDropDown.SelectedIndexChanged += new System.EventHandler(this.fontSizeDropDown_SelectedIndexChanged);
            // 
            // fontDropDown
            // 
            this.fontDropDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontDropDown.FormattingEnabled = true;
            this.fontDropDown.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Calibri (Body)",
            "Source Code Pro Medium",
            "Times New Roman"});
            this.fontDropDown.Location = new System.Drawing.Point(393, 15);
            this.fontDropDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fontDropDown.Name = "fontDropDown";
            this.fontDropDown.Size = new System.Drawing.Size(180, 28);
            this.fontDropDown.TabIndex = 0;
            this.fontDropDown.SelectedIndexChanged += new System.EventHandler(this.fontDropDown_SelectedIndexChanged);
            // 
            // textEditorFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 613);
            this.Controls.Add(this.fileMenu);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.bottomToolBar);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.topToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(700, 501);
            this.Name = "textEditorFrame";
            this.Text = "Text Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.textEditorFrame_FormClosed);
            this.Load += new System.EventHandler(this.textEditorFrame_Load);
            this.topToolBar.ResumeLayout(false);
            this.topToolBar.PerformLayout();
            this.fileMenu.ResumeLayout(false);
            this.bottomToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topToolBar;
        private System.Windows.Forms.Button duckBtn;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button fileMenuBtn;
        private System.Windows.Forms.Panel fileMenu;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Panel bottomToolBar;
        private System.Windows.Forms.ComboBox fontDropDown;
        private System.Windows.Forms.ComboBox fontSizeDropDown;
        private System.Windows.Forms.ComboBox fontColorDropDown;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button saveAsBtn;
    }
}

