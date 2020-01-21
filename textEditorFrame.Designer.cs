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
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.divider = new System.Windows.Forms.Panel();
            this.bottomToolBar = new System.Windows.Forms.Panel();
            this.fontColorDropDown = new System.Windows.Forms.ComboBox();
            this.fontSizeDropDown = new System.Windows.Forms.ComboBox();
            this.fontDropDown = new System.Windows.Forms.ComboBox();
            this.topToolBar.SuspendLayout();
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
            this.topToolBar.Margin = new System.Windows.Forms.Padding(2);
            this.topToolBar.Name = "topToolBar";
            this.topToolBar.Size = new System.Drawing.Size(1038, 88);
            this.topToolBar.TabIndex = 1;
            // 
            // fileMenuBtn
            // 
            this.fileMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenuBtn.Location = new System.Drawing.Point(90, 49);
            this.fileMenuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fileMenuBtn.Name = "fileMenuBtn";
            this.fileMenuBtn.Size = new System.Drawing.Size(52, 28);
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
            this.fileNameBox.Location = new System.Drawing.Point(90, 11);
            this.fileNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(224, 29);
            this.fileNameBox.TabIndex = 0;
            this.fileNameBox.WordWrap = false;
            // 
            // duckBtn
            // 
            this.duckBtn.BackgroundImage = global::QuackyDocsV2Desktop.Properties.Resources.DuckButton;
            this.duckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.duckBtn.Location = new System.Drawing.Point(9, 11);
            this.duckBtn.Margin = new System.Windows.Forms.Padding(2);
            this.duckBtn.Name = "duckBtn";
            this.duckBtn.Size = new System.Drawing.Size(67, 66);
            this.duckBtn.TabIndex = 0;
            this.duckBtn.UseVisualStyleBackColor = true;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.fileMenu.Location = new System.Drawing.Point(90, 77);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(144, 215);
            this.fileMenu.TabIndex = 2;
            this.fileMenu.Visible = false;
            // 
            // textArea
            // 
            this.textArea.BackColor = System.Drawing.Color.Silver;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(0, 149);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(1038, 383);
            this.textArea.TabIndex = 4;
            this.textArea.Text = "";
            this.textArea.Click += new System.EventHandler(this.textArea_Click);
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divider.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider.Location = new System.Drawing.Point(0, 88);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(1038, 10);
            this.divider.TabIndex = 5;
            // 
            // bottomToolBar
            // 
            this.bottomToolBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.bottomToolBar.Controls.Add(this.fontColorDropDown);
            this.bottomToolBar.Controls.Add(this.fontSizeDropDown);
            this.bottomToolBar.Controls.Add(this.fontDropDown);
            this.bottomToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomToolBar.Location = new System.Drawing.Point(0, 98);
            this.bottomToolBar.Name = "bottomToolBar";
            this.bottomToolBar.Size = new System.Drawing.Size(1038, 51);
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
            this.fontColorDropDown.Location = new System.Drawing.Point(569, 12);
            this.fontColorDropDown.Name = "fontColorDropDown";
            this.fontColorDropDown.Size = new System.Drawing.Size(121, 28);
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
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.fontSizeDropDown.Location = new System.Drawing.Point(492, 12);
            this.fontSizeDropDown.Name = "fontSizeDropDown";
            this.fontSizeDropDown.Size = new System.Drawing.Size(59, 28);
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
            "Ariel",
            "Source Code Pro"});
            this.fontDropDown.Location = new System.Drawing.Point(336, 12);
            this.fontDropDown.Name = "fontDropDown";
            this.fontDropDown.Size = new System.Drawing.Size(136, 28);
            this.fontDropDown.TabIndex = 0;
            this.fontDropDown.SelectedIndexChanged += new System.EventHandler(this.fontDropDown_SelectedIndexChanged);
            // 
            // textEditorFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 532);
            this.Controls.Add(this.fileMenu);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.bottomToolBar);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.topToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(529, 414);
            this.Name = "textEditorFrame";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.textEditorFrame_Load);
            this.topToolBar.ResumeLayout(false);
            this.topToolBar.PerformLayout();
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
    }
}

