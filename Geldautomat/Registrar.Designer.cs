namespace Geldautomat
{
    partial class Registrar
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
            this.txt_ping = new System.Windows.Forms.TextBox();
            this.txt_montoinicial = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_montoinicial = new System.Windows.Forms.Label();
            this.lbl_ping = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ping
            // 
            this.txt_ping.Location = new System.Drawing.Point(155, 217);
            this.txt_ping.Name = "txt_ping";
            this.txt_ping.Size = new System.Drawing.Size(100, 20);
            this.txt_ping.TabIndex = 17;
            // 
            // txt_montoinicial
            // 
            this.txt_montoinicial.Location = new System.Drawing.Point(155, 267);
            this.txt_montoinicial.Name = "txt_montoinicial";
            this.txt_montoinicial.Size = new System.Drawing.Size(100, 20);
            this.txt_montoinicial.TabIndex = 16;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(155, 171);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 15;
            // 
            // lbl_montoinicial
            // 
            this.lbl_montoinicial.AutoSize = true;
            this.lbl_montoinicial.Location = new System.Drawing.Point(68, 267);
            this.lbl_montoinicial.Name = "lbl_montoinicial";
            this.lbl_montoinicial.Size = new System.Drawing.Size(81, 13);
            this.lbl_montoinicial.TabIndex = 14;
            this.lbl_montoinicial.Text = "Cantidad inicial:";
            // 
            // lbl_ping
            // 
            this.lbl_ping.AutoSize = true;
            this.lbl_ping.Location = new System.Drawing.Point(118, 217);
            this.lbl_ping.Name = "lbl_ping";
            this.lbl_ping.Size = new System.Drawing.Size(31, 13);
            this.lbl_ping.TabIndex = 13;
            this.lbl_ping.Text = "Ping:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(102, 174);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 12;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ping);
            this.Controls.Add(this.txt_montoinicial);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_montoinicial);
            this.Controls.Add(this.lbl_ping);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ping;
        private System.Windows.Forms.TextBox txt_montoinicial;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_montoinicial;
        private System.Windows.Forms.Label lbl_ping;
        private System.Windows.Forms.Label lbl_nombre;
    }
}