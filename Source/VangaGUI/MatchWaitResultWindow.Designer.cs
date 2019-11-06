namespace VangaGUI
{
    partial class MatchWaitResultWindow
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
            this.EndLerning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndLerning
            // 
            this.EndLerning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EndLerning.Location = new System.Drawing.Point(435, 189);
            this.EndLerning.Name = "EndLerning";
            this.EndLerning.Size = new System.Drawing.Size(88, 47);
            this.EndLerning.TabIndex = 24;
            this.EndLerning.Text = "Закончить обучение";
            this.EndLerning.UseVisualStyleBackColor = false;
            this.EndLerning.Click += new System.EventHandler(this.EndLerning_Click);
            // 
            // MatchWaitResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 248);
            this.Controls.Add(this.EndLerning);
            this.Name = "MatchWaitResultWindow";
            this.Text = "MatchWaitResultWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EndLerning;
    }
}