namespace SmallProgramsShowcase
{
    partial class FormWordCount
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
            this.rtbStory = new System.Windows.Forms.RichTextBox();
            this.rtbCount = new System.Windows.Forms.RichTextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type your story below, and then press Count.";
            // 
            // rtbStory
            // 
            this.rtbStory.Location = new System.Drawing.Point(15, 48);
            this.rtbStory.Name = "rtbStory";
            this.rtbStory.Size = new System.Drawing.Size(511, 172);
            this.rtbStory.TabIndex = 1;
            this.rtbStory.Text = "";
            // 
            // rtbCount
            // 
            this.rtbCount.Location = new System.Drawing.Point(549, 48);
            this.rtbCount.Name = "rtbCount";
            this.rtbCount.ReadOnly = true;
            this.rtbCount.Size = new System.Drawing.Size(176, 327);
            this.rtbCount.TabIndex = 2;
            this.rtbCount.Text = "";
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.SystemColors.Window;
            this.btnCount.Location = new System.Drawing.Point(227, 226);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(85, 29);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(607, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FormWordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.rtbCount);
            this.Controls.Add(this.rtbStory);
            this.Controls.Add(this.label1);
            this.Name = "FormWordCount";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbStory;
        private System.Windows.Forms.RichTextBox rtbCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClose;
    }
}