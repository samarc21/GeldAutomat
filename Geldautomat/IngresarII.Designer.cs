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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarII));
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_loginpin = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Pin = new System.Windows.Forms.Label();
            this.btn_ingresarLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(178, 164);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(148, 27);
            this.txt_user.TabIndex = 15;
            // 
            // txt_loginpin
            // 
            this.txt_loginpin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_loginpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginpin.Location = new System.Drawing.Point(178, 227);
            this.txt_loginpin.Multiline = true;
            this.txt_loginpin.Name = "txt_loginpin";
            this.txt_loginpin.Size = new System.Drawing.Size(148, 27);
            this.txt_loginpin.TabIndex = 16;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(62, 164);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(93, 27);
            this.Usuario.TabIndex = 17;
            this.Usuario.Text = "Usuario";
            // 
            // Pin
            // 
            this.Pin.AutoSize = true;
            this.Pin.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin.Location = new System.Drawing.Point(108, 227);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(47, 27);
            this.Pin.TabIndex = 18;
            this.Pin.Text = "Pin";
            // 
            // btn_ingresarLog
            // 
            this.btn_ingresarLog.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresarLog.Location = new System.Drawing.Point(127, 324);
            this.btn_ingresarLog.Name = "btn_ingresarLog";
            this.btn_ingresarLog.Size = new System.Drawing.Size(131, 39);
            this.btn_ingresarLog.TabIndex = 19;
            this.btn_ingresarLog.Text = "Ingresar";
            this.btn_ingresarLog.UseVisualStyleBackColor = true;
            this.btn_ingresarLog.Click += new System.EventHandler(this.btn_ingresarLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(67, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(264, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // IngresarII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(380, 528);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_loginpin;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Pin;
        private System.Windows.Forms.Button btn_ingresarLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}