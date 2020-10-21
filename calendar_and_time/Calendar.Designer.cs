namespace calendar_and_time
{
    partial class Calendar
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
            this.components = new System.ComponentModel.Container();
            this.monthCalendarTo = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendarFrom = new System.Windows.Forms.MonthCalendar();
            this.calcButton = new System.Windows.Forms.Button();
            this.resultRichBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // monthCalendarTo
            // 
            this.monthCalendarTo.Location = new System.Drawing.Point(513, 101);
            this.monthCalendarTo.MaxSelectionCount = 1;
            this.monthCalendarTo.Name = "monthCalendarTo";
            this.monthCalendarTo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(507, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Od";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendarFrom
            // 
            this.monthCalendarFrom.Location = new System.Drawing.Point(18, 101);
            this.monthCalendarFrom.MaxSelectionCount = 1;
            this.monthCalendarFrom.Name = "monthCalendarFrom";
            this.monthCalendarFrom.TabIndex = 4;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.Gold;
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(283, 275);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(234, 44);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Oblicz";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resultRichBox
            // 
            this.resultRichBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultRichBox.Location = new System.Drawing.Point(283, 344);
            this.resultRichBox.Name = "resultRichBox";
            this.resultRichBox.ReadOnly = true;
            this.resultRichBox.Size = new System.Drawing.Size(234, 43);
            this.resultRichBox.TabIndex = 7;
            this.resultRichBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultRichBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendarFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarTo);
            this.Name = "Calendar";
            this.Text = "LiczbaDni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendarFrom;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.RichTextBox resultRichBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}