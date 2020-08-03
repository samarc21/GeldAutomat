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
            this.Usuario = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_user = new MetroFramework.Controls.MetroTextBox();
            this.txt_loginpin = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(46, 63);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(56, 20);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(60, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(28, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Pin";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(125, 63);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(97, 23);
            this.txt_user.TabIndex = 2;
            // 
            // txt_loginpin
            // 
            this.txt_loginpin.Location = new System.Drawing.Point(125, 99);
            this.txt_loginpin.Name = "txt_loginpin";
            this.txt_loginpin.Size = new System.Drawing.Size(97, 23);
            this.txt_loginpin.TabIndex = 3;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(46, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(186, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Ingresar";
            // 
            // IngresarII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_loginpin);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "IngresarII";
            this.Text = "IngresarII";
            this.Load += new System.EventHandler(this.IngresarII_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Usuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_user;
        private MetroFramework.Controls.MetroTextBox txt_loginpin;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}