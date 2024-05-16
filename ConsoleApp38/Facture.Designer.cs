namespace ConsoleApp38
{
    partial class Facture
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.FlotteBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.ReserverBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConsoleApp38.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(751, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.FlotteBtn);
            this.panel1.Controls.Add(this.ClientBtn);
            this.panel1.Controls.Add(this.ReserverBtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 97);
            this.panel1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(510, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Maintenance";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FlotteBtn
            // 
            this.FlotteBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FlotteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.FlotteBtn.ForeColor = System.Drawing.Color.Black;
            this.FlotteBtn.Location = new System.Drawing.Point(378, 32);
            this.FlotteBtn.Name = "FlotteBtn";
            this.FlotteBtn.Size = new System.Drawing.Size(107, 24);
            this.FlotteBtn.TabIndex = 4;
            this.FlotteBtn.Text = "Flotte";
            this.FlotteBtn.UseVisualStyleBackColor = false;
            // 
            // ClientBtn
            // 
            this.ClientBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.ClientBtn.ForeColor = System.Drawing.Color.Black;
            this.ClientBtn.Location = new System.Drawing.Point(251, 31);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(107, 25);
            this.ClientBtn.TabIndex = 5;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = false;
            // 
            // ReserverBtn
            // 
            this.ReserverBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReserverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.ReserverBtn.ForeColor = System.Drawing.Color.Black;
            this.ReserverBtn.Location = new System.Drawing.Point(127, 33);
            this.ReserverBtn.Name = "ReserverBtn";
            this.ReserverBtn.Size = new System.Drawing.Size(107, 23);
            this.ReserverBtn.TabIndex = 1;
            this.ReserverBtn.Text = "Réservation";
            this.ReserverBtn.UseVisualStyleBackColor = false;
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.Facture_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FlotteBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button ReserverBtn;
    }
}