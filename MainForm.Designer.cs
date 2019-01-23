namespace DataBicycle
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listSearchResults = new System.Windows.Forms.ListBox();
            this.textSearchPrompt = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSearchResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listSearchResults.FormattingEnabled = true;
            this.listSearchResults.ItemHeight = 16;
            this.listSearchResults.Location = new System.Drawing.Point(0, 112);
            this.listSearchResults.Name = "listBox1";
            this.listSearchResults.Size = new System.Drawing.Size(791, 306);
            this.listSearchResults.TabIndex = 2;
            this.listSearchResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listSearchResults_MouseDoubleClick);
            // 
            // textSearchPrompt
            // 
            this.textSearchPrompt.Location = new System.Drawing.Point(12, 44);
            this.textSearchPrompt.Name = "textSearchPrompt";
            this.textSearchPrompt.Size = new System.Drawing.Size(628, 22);
            this.textSearchPrompt.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(646, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(133, 30);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(12, 72);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(124, 32);
            this.buttonShowAll.TabIndex = 1;
            this.buttonShowAll.Text = "Показать все";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.HelpToolStripMenuItem.Text = "О программе";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 418);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textSearchPrompt);
            this.Controls.Add(this.listSearchResults);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "DataBicycle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSearchResults;
        private System.Windows.Forms.TextBox textSearchPrompt;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}

