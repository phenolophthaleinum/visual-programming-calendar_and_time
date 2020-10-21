namespace calendar_and_time
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_12h = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczbaDniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(0, 111);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(544, 29);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_12h,
            this.hToolStripMenuItem1,
            this.binToolStripMenuItem,
            this.minutnikToolStripMenuItem,
            this.liczbaDniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_12h
            // 
            this.Menu_12h.Name = "Menu_12h";
            this.Menu_12h.Size = new System.Drawing.Size(38, 20);
            this.Menu_12h.Text = "12h";
            this.Menu_12h.Click += new System.EventHandler(this.format12hToolStripMenuItem_Click);
            // 
            // hToolStripMenuItem1
            // 
            this.hToolStripMenuItem1.Name = "hToolStripMenuItem1";
            this.hToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.hToolStripMenuItem1.Text = "24h";
            this.hToolStripMenuItem1.Click += new System.EventHandler(this.format24hToolStripMenuItem1_Click);
            // 
            // binToolStripMenuItem
            // 
            this.binToolStripMenuItem.Name = "binToolStripMenuItem";
            this.binToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.binToolStripMenuItem.Text = "Bin";
            this.binToolStripMenuItem.Click += new System.EventHandler(this.binToolStripMenuItem_Click);
            // 
            // minutnikToolStripMenuItem
            // 
            this.minutnikToolStripMenuItem.Name = "minutnikToolStripMenuItem";
            this.minutnikToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.minutnikToolStripMenuItem.Text = "Minutnik";
            this.minutnikToolStripMenuItem.Click += new System.EventHandler(this.minutnikToolStripMenuItem_Click);
            // 
            // liczbaDniToolStripMenuItem
            // 
            this.liczbaDniToolStripMenuItem.Name = "liczbaDniToolStripMenuItem";
            this.liczbaDniToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.liczbaDniToolStripMenuItem.Text = "LiczbaDni";
            this.liczbaDniToolStripMenuItem.Click += new System.EventHandler(this.liczbaDniToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 272);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Zegar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_12h;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liczbaDniToolStripMenuItem;
    }
}

