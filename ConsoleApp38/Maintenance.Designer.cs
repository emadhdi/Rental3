namespace ConsoleApp38
{
    partial class MaintenanceForm
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
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeMaintCombo = new System.Windows.Forms.ComboBox();
            this.ModeleCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datedebutM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datefinM = new System.Windows.Forms.DateTimePicker();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.RecherBtn = new System.Windows.Forms.Button();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.SupprBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FlotteBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.ReserverBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdTxt
            // 
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(289, 107);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(256, 26);
            this.IdTxt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type";
            // 
            // TypeMaintCombo
            // 
            this.TypeMaintCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeMaintCombo.FormattingEnabled = true;
            this.TypeMaintCombo.Location = new System.Drawing.Point(289, 173);
            this.TypeMaintCombo.Name = "TypeMaintCombo";
            this.TypeMaintCombo.Size = new System.Drawing.Size(256, 28);
            this.TypeMaintCombo.TabIndex = 18;
            // 
            // ModeleCombo
            // 
            this.ModeleCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeleCombo.FormattingEnabled = true;
            this.ModeleCombo.Location = new System.Drawing.Point(289, 139);
            this.ModeleCombo.Name = "ModeleCombo";
            this.ModeleCombo.Size = new System.Drawing.Size(256, 28);
            this.ModeleCombo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Modéle";
            // 
            // datedebutM
            // 
            this.datedebutM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedebutM.Location = new System.Drawing.Point(289, 207);
            this.datedebutM.Name = "datedebutM";
            this.datedebutM.Size = new System.Drawing.Size(256, 26);
            this.datedebutM.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date de début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date de fin";
            // 
            // datefinM
            // 
            this.datefinM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefinM.Location = new System.Drawing.Point(289, 239);
            this.datefinM.Name = "datefinM";
            this.datefinM.Size = new System.Drawing.Size(256, 26);
            this.datefinM.TabIndex = 24;
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierBtn.Location = new System.Drawing.Point(361, 295);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(118, 28);
            this.ModifierBtn.TabIndex = 28;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // RecherBtn
            // 
            this.RecherBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RecherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecherBtn.Location = new System.Drawing.Point(485, 296);
            this.RecherBtn.Name = "RecherBtn";
            this.RecherBtn.Size = new System.Drawing.Size(118, 28);
            this.RecherBtn.TabIndex = 27;
            this.RecherBtn.Text = "Rechercher";
            this.RecherBtn.UseVisualStyleBackColor = false;
            this.RecherBtn.Click += new System.EventHandler(this.RecherBtn_Click);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AjouterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterBtn.Location = new System.Drawing.Point(113, 295);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(118, 29);
            this.AjouterBtn.TabIndex = 25;
            this.AjouterBtn.Text = "Ajouter";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.AjouterBtn_Click);
            // 
            // SupprBtn
            // 
            this.SupprBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupprBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprBtn.Location = new System.Drawing.Point(237, 295);
            this.SupprBtn.Name = "SupprBtn";
            this.SupprBtn.Size = new System.Drawing.Size(118, 28);
            this.SupprBtn.TabIndex = 29;
            this.SupprBtn.Text = "Supprimer";
            this.SupprBtn.UseVisualStyleBackColor = false;
            this.SupprBtn.Click += new System.EventHandler(this.SupprBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.FlotteBtn);
            this.panel1.Controls.Add(this.ClientBtn);
            this.panel1.Controls.Add(this.ReserverBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 97);
            this.panel1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gestion de Maintenance";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(508, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Maintenance";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FlotteBtn
            // 
            this.FlotteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FlotteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.FlotteBtn.ForeColor = System.Drawing.Color.Black;
            this.FlotteBtn.Location = new System.Drawing.Point(376, 61);
            this.FlotteBtn.Name = "FlotteBtn";
            this.FlotteBtn.Size = new System.Drawing.Size(107, 24);
            this.FlotteBtn.TabIndex = 19;
            this.FlotteBtn.Text = "Flotte";
            this.FlotteBtn.UseVisualStyleBackColor = false;
            this.FlotteBtn.Click += new System.EventHandler(this.FlotteBtn_Click);
            // 
            // ClientBtn
            // 
            this.ClientBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.ClientBtn.ForeColor = System.Drawing.Color.Black;
            this.ClientBtn.Location = new System.Drawing.Point(249, 60);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(107, 25);
            this.ClientBtn.TabIndex = 20;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = false;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // ReserverBtn
            // 
            this.ReserverBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.ReserverBtn.ForeColor = System.Drawing.Color.Black;
            this.ReserverBtn.Location = new System.Drawing.Point(125, 62);
            this.ReserverBtn.Name = "ReserverBtn";
            this.ReserverBtn.Size = new System.Drawing.Size(107, 23);
            this.ReserverBtn.TabIndex = 18;
            this.ReserverBtn.Text = "Réservation";
            this.ReserverBtn.UseVisualStyleBackColor = false;
            this.ReserverBtn.Click += new System.EventHandler(this.ReserverBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleApp38.Properties.Resources.icons8_car_service_48;
            this.pictureBox1.Location = new System.Drawing.Point(40, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::ConsoleApp38.Properties.Resources.se_connecter;
            this.guna2Button1.Location = new System.Drawing.Point(12, 350);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(51, 35);
            this.guna2Button1.TabIndex = 50;
            this.guna2Button1.Text = " ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SupprBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.RecherBtn);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.datefinM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datedebutM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModeleCombo);
            this.Controls.Add(this.TypeMaintCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des maintenances";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeMaintCombo;
        private System.Windows.Forms.ComboBox ModeleCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datedebutM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datefinM;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button RecherBtn;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.Button SupprBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FlotteBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button ReserverBtn;
        private System.Windows.Forms.Label label5;
    }
}