namespace Geldautomat
{
    partial class IngresarII
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_loginpin = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Pin = new System.Windows.Forms.Label();
            this.btn_ingresarLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(251, 160);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 22);
            this.txt_user.TabIndex = 15;
            // 
            // txt_loginpin
            // 
            this.txt_loginpin.Location = new System.Drawing.Point(251, 194);
            this.txt_loginpin.Name = "txt_loginpin";
            this.txt_loginpin.Size = new System.Drawing.Size(100, 22);
            this.txt_loginpin.TabIndex = 16;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(143, 163);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(57, 17);
            this.Usuario.TabIndex = 17;
            this.Usuario.Text = "Usuario";
            // 
            // Pin
            // 
            this.Pin.AutoSize = true;
            this.Pin.Location = new System.Drawing.Point(143, 199);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(28, 17);
            this.Pin.TabIndex = 18;
            this.Pin.Text = "Pin";
            // 
            // btn_ingresarLog
            // 
            this.btn_ingresarLog.Location = new System.Drawing.Point(225, 264);
            this.btn_ingresarLog.Name = "btn_ingresarLog";
            this.btn_ingresarLog.Size = new System.Drawing.Size(103, 35);
            this.btn_ingresarLog.TabIndex = 19;
            this.btn_ingresarLog.Text = "Ingresar";
            this.btn_ingresarLog.UseVisualStyleBackColor = true;
            this.btn_ingresarLog.Click += new System.EventHandler(this.btn_ingresarLog_Click);
            // 
            // IngresarII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_ingresarLog);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txt_loginpin);
            this.Controls.Add(this.txt_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IngresarII";
            this.Text = "IngresarII";
            this.Load += new System.EventHandler(this.IngresarII_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_loginpin;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Pin;
        private System.Windows.Forms.Button btn_ingresarLog;
    }
}