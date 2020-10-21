namespace calendar_and_time
{
    partial class TimerAlarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.topicRichBox = new System.Windows.Forms.RichTextBox();
            this.timeRichBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topicRichBox
            // 
            this.topicRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicRichBox.Location = new System.Drawing.Point(12, 93);
            this.topicRichBox.Name = "topicRichBox";
            this.topicRichBox.Size = new System.Drawing.Size(238, 97);
            this.topicRichBox.TabIndex = 1;
            this.topicRichBox.Text = "";
            // 
            // timeRichBox
            // 
            this.timeRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeRichBox.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRichBox.Location = new System.Drawing.Point(12, 251);
            this.timeRichBox.Name = "timeRichBox";
            this.timeRichBox.Size = new System.Drawing.Size(238, 41);
            this.timeRichBox.TabIndex = 2;
            this.timeRichBox.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minuty";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.BackColor = System.Drawing.Color.PaleGreen;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(38, 326);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(185, 54);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // TimerAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 497);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeRichBox);
            this.Controls.Add(this.topicRichBox);
            this.Controls.Add(this.label1);
            this.Name = "TimerAlarm";
            this.Text = "Minutnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox topicRichBox;
        private System.Windows.Forms.RichTextBox timeRichBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
    }
}