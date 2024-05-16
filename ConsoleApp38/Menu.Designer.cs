namespace ConsoleApp38
{
    partial class Session_Agent
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
            this.ReserverBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FlotteBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ReserverBtn
            // 
            this.ReserverBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserverBtn.ForeColor = System.Drawing.Color.Black;
            this.ReserverBtn.Location = new System.Drawing.Point(77, 164);
            this.ReserverBtn.Name = "ReserverBtn";
            this.ReserverBtn.Size = new System.Drawing.Size(202, 55);
            this.ReserverBtn.TabIndex = 0;
            this.ReserverBtn.Text = "Réservation";
            this.ReserverBtn.UseVisualStyleBackColor = false;
            this.ReserverBtn.Click += new System.EventHandler(this.ReserverBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(481, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Maintenance";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FlotteBtn
            // 
            this.FlotteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FlotteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlotteBtn.ForeColor = System.Drawing.Color.Black;
            this.FlotteBtn.Location = new System.Drawing.Point(278, 94);
            this.FlotteBtn.Name = "FlotteBtn";
            this.FlotteBtn.Size = new System.Drawing.Size(202, 55);
            this.FlotteBtn.TabIndex = 3;
            this.FlotteBtn.Text = "Flotte";
            this.FlotteBtn.UseVisualStyleBackColor = false;
            this.FlotteBtn.Click += new System.EventHandler(this.FlotteBtn_Click);
            // 
            // ClientBtn
            // 
            this.ClientBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientBtn.ForeColor = System.Drawing.Color.Black;
            this.ClientBtn.Location = new System.Drawing.Point(278, 236);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(202, 55);
            this.ClientBtn.TabIndex = 4;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = false;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(33, 345);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(51, 35);
            this.guna2Button1.TabIndex = 50;
            this.guna2Button1.Text = " ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Session_Agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ClientBtn);
            this.Controls.Add(this.FlotteBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ReserverBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Session_Agent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeriAuto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReserverBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FlotteBtn;
        private System.Windows.Forms.Button ClientBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}