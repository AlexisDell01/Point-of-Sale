namespace Sol_PuntoVenta.Presentacion
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_login_us = new System.Windows.Forms.TextBox();
            this.Txt_Password_us = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Acceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pct_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.Pct_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 291);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(167, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iniciar Sesión";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(264, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario:";
            // 
            // Txt_login_us
            // 
            this.Txt_login_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_login_us.Location = new System.Drawing.Point(267, 92);
            this.Txt_login_us.MaxLength = 20;
            this.Txt_login_us.Name = "Txt_login_us";
            this.Txt_login_us.Size = new System.Drawing.Size(256, 26);
            this.Txt_login_us.TabIndex = 3;
            // 
            // Txt_Password_us
            // 
            this.Txt_Password_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password_us.Location = new System.Drawing.Point(267, 181);
            this.Txt_Password_us.MaxLength = 20;
            this.Txt_Password_us.Name = "Txt_Password_us";
            this.Txt_Password_us.PasswordChar = '*';
            this.Txt_Password_us.Size = new System.Drawing.Size(256, 26);
            this.Txt_Password_us.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(264, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña:";
            // 
            // Btn_Acceder
            // 
            this.Btn_Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(129)))));
            this.Btn_Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Acceder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Acceder.ForeColor = System.Drawing.Color.White;
            this.Btn_Acceder.Location = new System.Drawing.Point(309, 230);
            this.Btn_Acceder.Name = "Btn_Acceder";
            this.Btn_Acceder.Size = new System.Drawing.Size(162, 40);
            this.Btn_Acceder.TabIndex = 6;
            this.Btn_Acceder.Text = "Acceder";
            this.Btn_Acceder.UseVisualStyleBackColor = false;
            this.Btn_Acceder.Click += new System.EventHandler(this.Btn_Acceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Pct_logo
            // 
            this.Pct_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pct_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pct_logo.Image")));
            this.Pct_logo.Location = new System.Drawing.Point(12, 92);
            this.Pct_logo.Name = "Pct_logo";
            this.Pct_logo.Size = new System.Drawing.Size(137, 113);
            this.Pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pct_logo.TabIndex = 1;
            this.Pct_logo.TabStop = false;
            this.Pct_logo.Click += new System.EventHandler(this.Pct_logo_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(632, 291);
            this.Controls.Add(this.Btn_Acceder);
            this.Controls.Add(this.Txt_Password_us);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_login_us);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_login_us;
        private System.Windows.Forms.TextBox Txt_Password_us;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Acceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pct_logo;
    }
}