namespace PZSavior.UI
{
    partial class WaitModal
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
            LblTitle = new System.Windows.Forms.Label();
            LblTask = new System.Windows.Forms.Label();
            LblProgress = new System.Windows.Forms.Label();
            PbarProgress = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.BackColor = System.Drawing.Color.Transparent;
            LblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            LblTitle.Location = new System.Drawing.Point(26, 23);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new System.Drawing.Size(206, 56);
            LblTitle.TabIndex = 0;
            LblTitle.Text = "Title";
            LblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblTask
            // 
            LblTask.BackColor = System.Drawing.Color.Transparent;
            LblTask.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblTask.ForeColor = System.Drawing.Color.Black;
            LblTask.Location = new System.Drawing.Point(26, 175);
            LblTask.Name = "LblTask";
            LblTask.Size = new System.Drawing.Size(206, 24);
            LblTask.TabIndex = 0;
            LblTask.Text = "Title";
            LblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblProgress
            // 
            LblProgress.BackColor = System.Drawing.Color.Transparent;
            LblProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblProgress.ForeColor = System.Drawing.Color.Black;
            LblProgress.Location = new System.Drawing.Point(81, 204);
            LblProgress.Name = "LblProgress";
            LblProgress.Size = new System.Drawing.Size(96, 23);
            LblProgress.TabIndex = 0;
            LblProgress.Text = "Title";
            LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbarProgress
            // 
            PbarProgress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            PbarProgress.ForeColor = System.Drawing.Color.Red;
            PbarProgress.Location = new System.Drawing.Point(-2, 235);
            PbarProgress.Name = "PbarProgress";
            PbarProgress.Size = new System.Drawing.Size(260, 23);
            PbarProgress.Step = 1;
            PbarProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            PbarProgress.TabIndex = 1;
            // 
            // WaitModal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            BackgroundImage = Properties.Resources.pz_icon;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(256, 256);
            Controls.Add(PbarProgress);
            Controls.Add(LblProgress);
            Controls.Add(LblTask);
            Controls.Add(LblTitle);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "WaitModal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "WaitModal";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblTask;
        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.ProgressBar PbarProgress;
    }
}