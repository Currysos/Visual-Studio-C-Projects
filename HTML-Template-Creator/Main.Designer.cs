namespace HTML_Template_Creator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Header = new System.Windows.Forms.Label();
            this.DirectoryInput = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DoneText = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.BrowsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AccessibleDescription = "Header for the form, says create a website template";
            this.Header.AccessibleName = "Header";
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Header.Location = new System.Drawing.Point(75, 11);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(445, 49);
            this.Header.TabIndex = 0;
            this.Header.Text = "Create a Website Template";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // DirectoryInput
            // 
            this.DirectoryInput.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryInput.Location = new System.Drawing.Point(75, 110);
            this.DirectoryInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DirectoryInput.Name = "DirectoryInput";
            this.DirectoryInput.Size = new System.Drawing.Size(335, 32);
            this.DirectoryInput.TabIndex = 1;
            this.DirectoryInput.Text = "Directory (C:\\users\\...)";
            this.DirectoryInput.TextChanged += new System.EventHandler(this.DirectoryInput_TextChanged);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(68, 70);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(341, 35);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Where do you want to start?";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(75, 258);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(445, 38);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create!";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(68, 149);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(210, 35);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name of project?";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(75, 188);
            this.NameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(335, 32);
            this.NameInput.TabIndex = 5;
            this.NameInput.Text = "ProjectName";
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowser.SelectedPath = "C:\\Users\\Noah.hjerdin\\Documents";
            // 
            // DoneText
            // 
            this.DoneText.AutoSize = true;
            this.DoneText.BackColor = System.Drawing.Color.Transparent;
            this.DoneText.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneText.Location = new System.Drawing.Point(75, 304);
            this.DoneText.Name = "DoneText";
            this.DoneText.Size = new System.Drawing.Size(0, 24);
            this.DoneText.TabIndex = 7;
            // 
            // OpenButton
            // 
            this.OpenButton.Enabled = false;
            this.OpenButton.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(415, 306);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(104, 39);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // BrowsButton
            // 
            this.BrowsButton.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowsButton.Location = new System.Drawing.Point(415, 110);
            this.BrowsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowsButton.Name = "BrowsButton";
            this.BrowsButton.Size = new System.Drawing.Size(104, 32);
            this.BrowsButton.TabIndex = 3;
            this.BrowsButton.Text = "Brows";
            this.BrowsButton.UseVisualStyleBackColor = true;
            this.BrowsButton.Click += new System.EventHandler(this.BrowsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HTML_Template_Creator.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 356);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.DoneText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BrowsButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.DirectoryInput);
            this.Controls.Add(this.Header);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(599, 403);
            this.MinimumSize = new System.Drawing.Size(599, 403);
            this.Name = "Main";
            this.Text = "Website Creator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox DirectoryInput;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label DoneText;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button BrowsButton;
    }
}

