namespace calendar_and_time
{
    partial class AlarmNotification
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
            this.okButton = new System.Windows.Forms.Button();
            this.topicRichBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.BackColor = System.Drawing.Color.Gold;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(58, 328);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(185, 54);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // topicRichBox
            // 
            this.topicRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicRichBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicRichBox.Location = new System.Drawing.Point(32, 95);
            this.topicRichBox.Name = "topicRichBox";
            this.topicRichBox.ReadOnly = true;
            this.topicRichBox.Size = new System.Drawing.Size(238, 97);
            this.topicRichBox.TabIndex = 6;
            this.topicRichBox.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlarmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.topicRichBox);
            this.Controls.Add(this.label1);
            this.Name = "AlarmNotification";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.AlarmNotification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RichTextBox topicRichBox;
        private System.Windows.Forms.Label label1;
    }
}