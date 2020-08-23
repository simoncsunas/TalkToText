namespace sSpeech
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnSpeech = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbToSpeak = new System.Windows.Forms.RichTextBox();
            this.txtRecognize = new System.Windows.Forms.TextBox();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpeech
            // 
            this.btnSpeech.Location = new System.Drawing.Point(140, 205);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(69, 24);
            this.btnSpeech.TabIndex = 0;
            this.btnSpeech.Text = "Speak";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(215, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbToSpeak
            // 
            this.rtbToSpeak.Location = new System.Drawing.Point(13, 12);
            this.rtbToSpeak.Name = "rtbToSpeak";
            this.rtbToSpeak.Size = new System.Drawing.Size(280, 87);
            this.rtbToSpeak.TabIndex = 2;
            this.rtbToSpeak.Text = "";
            // 
            // txtRecognize
            // 
            this.txtRecognize.Location = new System.Drawing.Point(14, 106);
            this.txtRecognize.Name = "txtRecognize";
            this.txtRecognize.Size = new System.Drawing.Size(278, 20);
            this.txtRecognize.TabIndex = 3;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(65, 205);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(69, 24);
            this.btnRecognize.TabIndex = 4;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 241);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.txtRecognize);
            this.Controls.Add(this.rtbToSpeak);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSpeech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbToSpeak;
        private System.Windows.Forms.TextBox txtRecognize;
        private System.Windows.Forms.Button btnRecognize;
    }
}

