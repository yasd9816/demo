namespace TextToSpeechWindows
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
            this.txtVoice = new System.Windows.Forms.RichTextBox();
            this.btnTextToSpeech = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVoice
            // 
            this.txtVoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtVoice.Location = new System.Drawing.Point(0, 54);
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.Size = new System.Drawing.Size(800, 396);
            this.txtVoice.TabIndex = 0;
            this.txtVoice.Text = "";
            // 
            // btnTextToSpeech
            // 
            this.btnTextToSpeech.Location = new System.Drawing.Point(12, 12);
            this.btnTextToSpeech.Name = "btnTextToSpeech";
            this.btnTextToSpeech.Size = new System.Drawing.Size(146, 36);
            this.btnTextToSpeech.TabIndex = 1;
            this.btnTextToSpeech.Text = "Text To Speech";
            this.btnTextToSpeech.UseVisualStyleBackColor = true;
            this.btnTextToSpeech.Click += new System.EventHandler(this.btnTextToSpeech_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTextToSpeech);
            this.Controls.Add(this.txtVoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtVoice;
        private System.Windows.Forms.Button btnTextToSpeech;
    }
}

