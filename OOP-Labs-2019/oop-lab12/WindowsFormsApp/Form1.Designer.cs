namespace WindowsFormsApp
{
    partial class Form1
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEncrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecrypt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUnarchive = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxListFiles = new System.Windows.Forms.TextBox();
            this.buttonChooseFiles = new System.Windows.Forms.Button();
            this.buttonClearFiles = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemMenu
            // 
            this.toolStripMenuItemMenu.BackColor = System.Drawing.Color.Purple;
            this.toolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEncrypt,
            this.toolStripMenuItemDecrypt,
            this.toolStripMenuItemArchive,
            this.toolStripMenuItemUnarchive});
            this.toolStripMenuItemMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMenuItemMenu.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItemMenu.Name = "toolStripMenuItemMenu";
            this.toolStripMenuItemMenu.Size = new System.Drawing.Size(77, 27);
            this.toolStripMenuItemMenu.Text = "МЕНЮ";
            // 
            // toolStripMenuItemEncrypt
            // 
            this.toolStripMenuItemEncrypt.Name = "toolStripMenuItemEncrypt";
            this.toolStripMenuItemEncrypt.Size = new System.Drawing.Size(218, 28);
            this.toolStripMenuItemEncrypt.Text = "Шифрувати";
            this.toolStripMenuItemEncrypt.Click += new System.EventHandler(this.toolStripMenuItemEncrypt_Click);
            // 
            // toolStripMenuItemDecrypt
            // 
            this.toolStripMenuItemDecrypt.Name = "toolStripMenuItemDecrypt";
            this.toolStripMenuItemDecrypt.Size = new System.Drawing.Size(218, 28);
            this.toolStripMenuItemDecrypt.Text = "Розшифрувати";
            this.toolStripMenuItemDecrypt.Click += new System.EventHandler(this.toolStripMenuItemDecrypt_Click);
            // 
            // toolStripMenuItemArchive
            // 
            this.toolStripMenuItemArchive.Name = "toolStripMenuItemArchive";
            this.toolStripMenuItemArchive.Size = new System.Drawing.Size(218, 28);
            this.toolStripMenuItemArchive.Text = "Архівувати";
            this.toolStripMenuItemArchive.Click += new System.EventHandler(this.toolStripMenuItemArchive_Click);
            // 
            // toolStripMenuItemUnarchive
            // 
            this.toolStripMenuItemUnarchive.Name = "toolStripMenuItemUnarchive";
            this.toolStripMenuItemUnarchive.Size = new System.Drawing.Size(218, 28);
            this.toolStripMenuItemUnarchive.Text = "Розархівувати";
            this.toolStripMenuItemUnarchive.Click += new System.EventHandler(this.toolStripMenuItemUnarchive_Click);
            // 
            // textBoxListFiles
            // 
            this.textBoxListFiles.AllowDrop = true;
            this.textBoxListFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxListFiles.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxListFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxListFiles.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBoxListFiles.Location = new System.Drawing.Point(0, 31);
            this.textBoxListFiles.Multiline = true;
            this.textBoxListFiles.Name = "textBoxListFiles";
            this.textBoxListFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListFiles.Size = new System.Drawing.Size(587, 306);
            this.textBoxListFiles.TabIndex = 1;
            this.textBoxListFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxListFiles_DragDrop);
            this.textBoxListFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxListFiles_DragEnter);
            // 
            // buttonChooseFiles
            // 
            this.buttonChooseFiles.BackColor = System.Drawing.Color.Pink;
            this.buttonChooseFiles.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseFiles.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonChooseFiles.Location = new System.Drawing.Point(35, 355);
            this.buttonChooseFiles.Name = "buttonChooseFiles";
            this.buttonChooseFiles.Size = new System.Drawing.Size(188, 48);
            this.buttonChooseFiles.TabIndex = 2;
            this.buttonChooseFiles.Text = "Выбрать файл";
            this.buttonChooseFiles.UseVisualStyleBackColor = false;
            this.buttonChooseFiles.Click += new System.EventHandler(this.buttonChooseFiles_Click);
            // 
            // buttonClearFiles
            // 
            this.buttonClearFiles.BackColor = System.Drawing.Color.Pink;
            this.buttonClearFiles.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFiles.ForeColor = System.Drawing.Color.DarkViolet;
            this.buttonClearFiles.Location = new System.Drawing.Point(242, 355);
            this.buttonClearFiles.Name = "buttonClearFiles";
            this.buttonClearFiles.Size = new System.Drawing.Size(216, 48);
            this.buttonClearFiles.TabIndex = 3;
            this.buttonClearFiles.Text = "Очистить список";
            this.buttonClearFiles.UseVisualStyleBackColor = false;
            this.buttonClearFiles.Click += new System.EventHandler(this.buttonClearFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 420);
            this.Controls.Add(this.buttonClearFiles);
            this.Controls.Add(this.buttonChooseFiles);
            this.Controls.Add(this.textBoxListFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторна робота №12, Харипончук М.М., гр. ПІ-60";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEncrypt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecrypt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUnarchive;
        private System.Windows.Forms.TextBox textBoxListFiles;
        private System.Windows.Forms.Button buttonChooseFiles;
        private System.Windows.Forms.Button buttonClearFiles;
    }
}

