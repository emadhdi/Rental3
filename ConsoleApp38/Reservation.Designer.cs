namespace ConsoleApp38
{
    partial class Reservation
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
            this.Fin = new System.Windows.Forms.Label();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.DataGrid1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ReserverDataGrid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsulterBtn = new System.Windows.Forms.Button();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.MarqueTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModeleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrixTxt = new System.Windows.Forms.TextBox();
            this.AvanceTxt = new System.Windows.Forms.TextBox();
            this.Avancelabel = new System.Windows.Forms.Label();
            this.ResteTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AjouterClientBtn = new System.Windows.Forms.Button();
            this.ClientActLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.FlotteBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.ReserverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de début";
            // 
            // Fin
            // 
            this.Fin.AutoSize = true;
            this.Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fin.Location = new System.Drawing.Point(136, 56);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(77, 17);
            this.Fin.TabIndex = 1;
            this.Fin.Text = "Date de fin";
            // 
            // DateDebut
            // 
            this.DateDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDebut.Location = new System.Drawing.Point(240, 22);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(255, 23);
            this.DateDebut.TabIndex = 4;
            // 
            // DataGrid1
            // 
            this.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Location = new System.Drawing.Point(289, 212);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(446, 149);
            this.DataGrid1.TabIndex = 6;
            this.DataGrid1.SelectionChanged += new System.EventHandler(this.DataGrid1_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voitures disponibles";
            // 
            // ReserverDataGrid
            // 
            this.ReserverDataGrid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserverDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserverDataGrid.Location = new System.Drawing.Point(411, 367);
            this.ReserverDataGrid.Name = "ReserverDataGrid";
            this.ReserverDataGrid.Size = new System.Drawing.Size(256, 27);
            this.ReserverDataGrid.TabIndex = 8;
            this.ReserverDataGrid.Text = "Réserver";
            this.ReserverDataGrid.UseVisualStyleBackColor = false;
            this.ReserverDataGrid.Click += new System.EventHandler(this.ReserverDataGrid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConsulterBtn);
            this.groupBox1.Controls.Add(this.DateFin);
            this.groupBox1.Controls.Add(this.Fin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateDebut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulter la disponibilité";
            // 
            // ConsulterBtn
            // 
            this.ConsulterBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ConsulterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsulterBtn.Location = new System.Drawing.Point(524, 37);
            this.ConsulterBtn.Name = "ConsulterBtn";
            this.ConsulterBtn.Size = new System.Drawing.Size(94, 23);
            this.ConsulterBtn.TabIndex = 15;
            this.ConsulterBtn.Text = "Consulter";
            this.ConsulterBtn.UseVisualStyleBackColor = false;
            this.ConsulterBtn.Click += new System.EventHandler(this.ConsulterBtn_Click_1);
            // 
            // DateFin
            // 
            this.DateFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFin.Location = new System.Drawing.Point(240, 55);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(255, 23);
            this.DateFin.TabIndex = 11;
            // 
            // MarqueTxt
            // 
            this.MarqueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarqueTxt.Location = new System.Drawing.Point(104, 212);
            this.MarqueTxt.Name = "MarqueTxt";
            this.MarqueTxt.Size = new System.Drawing.Size(172, 23);
            this.MarqueTxt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Marque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Modéle";
            // 
            // ModeleTxt
            // 
            this.ModeleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeleTxt.Location = new System.Drawing.Point(104, 247);
            this.ModeleTxt.Name = "ModeleTxt";
            this.ModeleTxt.Size = new System.Drawing.Size(172, 23);
            this.ModeleTxt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prix";
            // 
            // PrixTxt
            // 
            this.PrixTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixTxt.Location = new System.Drawing.Point(104, 305);
            this.PrixTxt.Name = "PrixTxt";
            this.PrixTxt.Size = new System.Drawing.Size(172, 23);
            this.PrixTxt.TabIndex = 15;
            // 
            // AvanceTxt
            // 
            this.AvanceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvanceTxt.Location = new System.Drawing.Point(104, 276);
            this.AvanceTxt.Name = "AvanceTxt";
            this.AvanceTxt.Size = new System.Drawing.Size(172, 23);
            this.AvanceTxt.TabIndex = 17;
            this.AvanceTxt.TextChanged += new System.EventHandler(this.AvanceTxt_TextChanged);
            // 
            // Avancelabel
            // 
            this.Avancelabel.AutoSize = true;
            this.Avancelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avancelabel.Location = new System.Drawing.Point(41, 275);
            this.Avancelabel.Name = "Avancelabel";
            this.Avancelabel.Size = new System.Drawing.Size(55, 17);
            this.Avancelabel.TabIndex = 18;
            this.Avancelabel.Text = "Avance";
            // 
            // ResteTxt
            // 
            this.ResteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResteTxt.Location = new System.Drawing.Point(104, 338);
            this.ResteTxt.Name = "ResteTxt";
            this.ResteTxt.Size = new System.Drawing.Size(172, 23);
            this.ResteTxt.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Reste";
            // 
            // AjouterClientBtn
            // 
            this.AjouterClientBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AjouterClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterClientBtn.Location = new System.Drawing.Point(163, 367);
            this.AjouterClientBtn.Name = "AjouterClientBtn";
            this.AjouterClientBtn.Size = new System.Drawing.Size(72, 27);
            this.AjouterClientBtn.TabIndex = 21;
            this.AjouterClientBtn.Text = "Ajouter";
            this.AjouterClientBtn.UseVisualStyleBackColor = false;
            this.AjouterClientBtn.Click += new System.EventHandler(this.AjouterClientBtn_Click);
            // 
            // ClientActLabel
            // 
            this.ClientActLabel.AutoSize = true;
            this.ClientActLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientActLabel.Location = new System.Drawing.Point(101, 372);
            this.ClientActLabel.Name = "ClientActLabel";
            this.ClientActLabel.Size = new System.Drawing.Size(43, 17);
            this.ClientActLabel.TabIndex = 22;
            this.ClientActLabel.Text = "Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.FlotteBtn);
            this.panel1.Controls.Add(this.ClientBtn);
            this.panel1.Controls.Add(this.ReserverBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 97);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(521, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Maintenance";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FlotteBtn
            // 
            this.FlotteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FlotteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.FlotteBtn.ForeColor = System.Drawing.Color.Black;
            this.FlotteBtn.Location = new System.Drawing.Point(389, 59);
            this.FlotteBtn.Name = "FlotteBtn";
            this.FlotteBtn.Size = new System.Drawing.Size(107, 24);
            this.FlotteBtn.TabIndex = 4;
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
            this.ClientBtn.Location = new System.Drawing.Point(262, 58);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(107, 25);
            this.ClientBtn.TabIndex = 5;
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
            this.ReserverBtn.Location = new System.Drawing.Point(138, 60);
            this.ReserverBtn.Name = "ReserverBtn";
            this.ReserverBtn.Size = new System.Drawing.Size(107, 23);
            this.ReserverBtn.TabIndex = 1;
            this.ReserverBtn.Text = "Réservation";
            this.ReserverBtn.UseVisualStyleBackColor = false;
            this.ReserverBtn.Click += new System.EventHandler(this.ReserverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion des Réservations";
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
            this.guna2Button1.Location = new System.Drawing.Point(10, 363);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(51, 35);
            this.guna2Button1.TabIndex = 51;
            this.guna2Button1.Text = " ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClientActLabel);
            this.Controls.Add(this.AjouterClientBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ResteTxt);
            this.Controls.Add(this.Avancelabel);
            this.Controls.Add(this.AvanceTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrixTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ModeleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MarqueTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReserverDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fin;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.DataGridView DataGrid1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReserverDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.Button ConsulterBtn;
        private System.Windows.Forms.TextBox MarqueTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModeleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PrixTxt;
        private System.Windows.Forms.TextBox AvanceTxt;
        private System.Windows.Forms.Label Avancelabel;
        private System.Windows.Forms.TextBox ResteTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AjouterClientBtn;
        private System.Windows.Forms.Label ClientActLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button ReserverBtn;
        private System.Windows.Forms.Button FlotteBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button button2;
    }
}