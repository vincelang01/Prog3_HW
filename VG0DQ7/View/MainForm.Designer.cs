namespace VG0DQ7.View
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlBetöltésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkalapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlBetöltésToolStripMenuItem,
            this.munkalapToolStripMenuItem,
            this.fizetésToolStripMenuItem,
            this.névjegToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlBetöltésToolStripMenuItem
            // 
            this.fájlBetöltésToolStripMenuItem.Name = "fájlBetöltésToolStripMenuItem";
            this.fájlBetöltésToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.fájlBetöltésToolStripMenuItem.Text = "Fájl betöltés...";
            this.fájlBetöltésToolStripMenuItem.Click += new System.EventHandler(this.fájlBetöltésToolStripMenuItem_Click);
            // 
            // munkalapToolStripMenuItem
            // 
            this.munkalapToolStripMenuItem.Name = "munkalapToolStripMenuItem";
            this.munkalapToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.munkalapToolStripMenuItem.Text = "Munkalap...";
            this.munkalapToolStripMenuItem.Click += new System.EventHandler(this.munkalapToolStripMenuItem_Click);
            // 
            // fizetésToolStripMenuItem
            // 
            this.fizetésToolStripMenuItem.Name = "fizetésToolStripMenuItem";
            this.fizetésToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.fizetésToolStripMenuItem.Text = "Fizetés...";
            this.fizetésToolStripMenuItem.Click += new System.EventHandler(this.fizetésToolStripMenuItem_Click);
            // 
            // névjegToolStripMenuItem
            // 
            this.névjegToolStripMenuItem.Name = "névjegToolStripMenuItem";
            this.névjegToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.névjegToolStripMenuItem.Text = "Névjegy...";
            this.névjegToolStripMenuItem.Click += new System.EventHandler(this.névjegToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VG0DQ7.Properties.Resources.female_automotive_mechanic_repair_car_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Szerviz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlBetöltésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkalapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
    }
}