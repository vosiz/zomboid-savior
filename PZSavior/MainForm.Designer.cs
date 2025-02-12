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
            LblInfo = new System.Windows.Forms.Label();
            CboxVersion = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            TboxSave = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            BtnSavesDefault = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            BtnLoadSaves = new System.Windows.Forms.Button();
            BtnLoadsDefault = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            TboxStorage = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // LblInfo
            // 
            LblInfo.BackColor = System.Drawing.Color.Black;
            LblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblInfo.ForeColor = System.Drawing.Color.Lime;
            LblInfo.Location = new System.Drawing.Point(85, 386);
            LblInfo.Name = "LblInfo";
            LblInfo.Padding = new System.Windows.Forms.Padding(6);
            LblInfo.Size = new System.Drawing.Size(703, 73);
            LblInfo.TabIndex = 0;
            LblInfo.Text = "-- Info here";
            // 
            // CboxVersion
            // 
            CboxVersion.FormattingEnabled = true;
            CboxVersion.Location = new System.Drawing.Point(33, 37);
            CboxVersion.Name = "CboxVersion";
            CboxVersion.Size = new System.Drawing.Size(147, 23);
            CboxVersion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 21);
            label1.TabIndex = 2;
            label1.Text = "Compatibility";
            // 
            // TboxSave
            // 
            TboxSave.Location = new System.Drawing.Point(33, 216);
            TboxSave.Name = "TboxSave";
            TboxSave.Size = new System.Drawing.Size(494, 23);
            TboxSave.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(12, 187);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 21);
            label2.TabIndex = 4;
            label2.Text = "Saves path";
            // 
            // BtnSavesDefault
            // 
            BtnSavesDefault.Location = new System.Drawing.Point(543, 215);
            BtnSavesDefault.Name = "BtnSavesDefault";
            BtnSavesDefault.Size = new System.Drawing.Size(75, 23);
            BtnSavesDefault.TabIndex = 5;
            BtnSavesDefault.Text = "Default";
            BtnSavesDefault.UseVisualStyleBackColor = true;
            BtnSavesDefault.Click += BtnSavesDefault_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(624, 215);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Scan";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new System.Drawing.Point(705, 215);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // BtnLoadSaves
            // 
            BtnLoadSaves.Location = new System.Drawing.Point(624, 82);
            BtnLoadSaves.Name = "BtnLoadSaves";
            BtnLoadSaves.Size = new System.Drawing.Size(164, 48);
            BtnLoadSaves.TabIndex = 6;
            BtnLoadSaves.Text = "Load saves";
            BtnLoadSaves.UseVisualStyleBackColor = true;
            BtnLoadSaves.Click += BtnLoadSaves_Click;
            // 
            // BtnLoadsDefault
            // 
            BtnLoadsDefault.Location = new System.Drawing.Point(543, 107);
            BtnLoadsDefault.Name = "BtnLoadsDefault";
            BtnLoadsDefault.Size = new System.Drawing.Size(75, 23);
            BtnLoadsDefault.TabIndex = 11;
            BtnLoadsDefault.Text = "Default";
            BtnLoadsDefault.UseVisualStyleBackColor = true;
            BtnLoadsDefault.Click += BtnLoadsDefault_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(12, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 21);
            label3.TabIndex = 8;
            label3.Text = "Storage path";
            // 
            // TboxStorage
            // 
            TboxStorage.Location = new System.Drawing.Point(33, 108);
            TboxStorage.Name = "TboxStorage";
            TboxStorage.Size = new System.Drawing.Size(494, 23);
            TboxStorage.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(580, 187);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(200, 20);
            label4.TabIndex = 12;
            label4.Text = "CTRL + S for quicksave";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.main;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label4);
            Controls.Add(BtnLoadsDefault);
            Controls.Add(label3);
            Controls.Add(TboxStorage);
            Controls.Add(BtnLoadSaves);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnSavesDefault);
            Controls.Add(label2);
            Controls.Add(TboxSave);
            Controls.Add(label1);
            Controls.Add(CboxVersion);
            Controls.Add(LblInfo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "PZ - save management tool";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
