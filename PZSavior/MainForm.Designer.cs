namespace PZSavior
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LblInfo = new System.Windows.Forms.Label();
            this.CboxVersion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxSave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSavesDefault = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnLoadSaves = new System.Windows.Forms.Button();
            this.BtnLoadsDefault = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TboxStorage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBackupSaves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.BackColor = System.Drawing.Color.Black;
            this.LblInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LblInfo.ForeColor = System.Drawing.Color.Lime;
            this.LblInfo.Location = new System.Drawing.Point(73, 335);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Padding = new System.Windows.Forms.Padding(5);
            this.LblInfo.Size = new System.Drawing.Size(603, 63);
            this.LblInfo.TabIndex = 0;
            this.LblInfo.Text = "-- Info here";
            // 
            // CboxVersion
            // 
            this.CboxVersion.FormattingEnabled = true;
            this.CboxVersion.Location = new System.Drawing.Point(28, 32);
            this.CboxVersion.Name = "CboxVersion";
            this.CboxVersion.Size = new System.Drawing.Size(127, 21);
            this.CboxVersion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compatibility";
            // 
            // TboxSave
            // 
            this.TboxSave.Location = new System.Drawing.Point(28, 187);
            this.TboxSave.Name = "TboxSave";
            this.TboxSave.Size = new System.Drawing.Size(342, 20);
            this.TboxSave.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saves path";
            // 
            // BtnSavesDefault
            // 
            this.BtnSavesDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSavesDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSavesDefault.FlatAppearance.BorderSize = 0;
            this.BtnSavesDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSavesDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSavesDefault.ForeColor = System.Drawing.Color.White;
            this.BtnSavesDefault.Location = new System.Drawing.Point(376, 179);
            this.BtnSavesDefault.Name = "BtnSavesDefault";
            this.BtnSavesDefault.Size = new System.Drawing.Size(94, 33);
            this.BtnSavesDefault.TabIndex = 5;
            this.BtnSavesDefault.Text = "Default";
            this.BtnSavesDefault.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(479, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(582, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // BtnLoadSaves
            // 
            this.BtnLoadSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLoadSaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadSaves.FlatAppearance.BorderSize = 0;
            this.BtnLoadSaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnLoadSaves.ForeColor = System.Drawing.Color.White;
            this.BtnLoadSaves.Location = new System.Drawing.Point(535, 12);
            this.BtnLoadSaves.Name = "BtnLoadSaves";
            this.BtnLoadSaves.Size = new System.Drawing.Size(145, 42);
            this.BtnLoadSaves.TabIndex = 6;
            this.BtnLoadSaves.Text = "Load saves";
            this.BtnLoadSaves.UseVisualStyleBackColor = false;
            this.BtnLoadSaves.Click += new System.EventHandler(this.BtnLoadSaves_Click);
            // 
            // BtnLoadsDefault
            // 
            this.BtnLoadsDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLoadsDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadsDefault.FlatAppearance.BorderSize = 0;
            this.BtnLoadsDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadsDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnLoadsDefault.ForeColor = System.Drawing.Color.White;
            this.BtnLoadsDefault.Location = new System.Drawing.Point(376, 86);
            this.BtnLoadsDefault.Name = "BtnLoadsDefault";
            this.BtnLoadsDefault.Size = new System.Drawing.Size(94, 33);
            this.BtnLoadsDefault.TabIndex = 11;
            this.BtnLoadsDefault.Text = "Default";
            this.BtnLoadsDefault.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Storage path";
            // 
            // TboxStorage
            // 
            this.TboxStorage.Location = new System.Drawing.Point(28, 94);
            this.TboxStorage.Name = "TboxStorage";
            this.TboxStorage.Size = new System.Drawing.Size(342, 20);
            this.TboxStorage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(476, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "CTRL + S for quicksave";
            // 
            // BtnBackupSaves
            // 
            this.BtnBackupSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBackupSaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackupSaves.FlatAppearance.BorderSize = 0;
            this.BtnBackupSaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackupSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnBackupSaves.ForeColor = System.Drawing.Color.White;
            this.BtnBackupSaves.Location = new System.Drawing.Point(376, 12);
            this.BtnBackupSaves.Name = "BtnBackupSaves";
            this.BtnBackupSaves.Size = new System.Drawing.Size(145, 42);
            this.BtnBackupSaves.TabIndex = 13;
            this.BtnBackupSaves.Text = "Backup all saves";
            this.BtnBackupSaves.UseVisualStyleBackColor = false;
            this.BtnBackupSaves.Click += new System.EventHandler(this.BtnBackupSaves_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PZSavior.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.BtnBackupSaves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnLoadsDefault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TboxStorage);
            this.Controls.Add(this.BtnLoadSaves);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSavesDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TboxSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboxVersion);
            this.Controls.Add(this.LblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PZ - save management tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.ComboBox CboxVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TboxSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSavesDefault;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnLoadSaves;
        private System.Windows.Forms.Button BtnLoadsDefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TboxStorage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBackupSaves;
    }
}
