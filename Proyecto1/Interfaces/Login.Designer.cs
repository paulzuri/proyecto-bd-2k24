namespace Interfaces
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.btnIngresa = new FontAwesome.Sharp.IconButton();
            this.btnCerra = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 247);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEMA DE RENTA";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 173;
            this.iconPictureBox1.Location = new System.Drawing.Point(97, 62);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(180, 173);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Documento ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.BackColor = System.Drawing.Color.Wheat;
            this.textBoxDocumento.Location = new System.Drawing.Point(435, 43);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(256, 22);
            this.textBoxDocumento.TabIndex = 5;
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.BackColor = System.Drawing.Color.Wheat;
            this.textBoxContrasenia.Location = new System.Drawing.Point(435, 120);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(256, 22);
            this.textBoxContrasenia.TabIndex = 6;
            // 
            // btnIngresa
            // 
            this.btnIngresa.BackColor = System.Drawing.Color.LightGreen;
            this.btnIngresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresa.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnIngresa.IconColor = System.Drawing.Color.Black;
            this.btnIngresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresa.IconSize = 30;
            this.btnIngresa.Location = new System.Drawing.Point(435, 173);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(117, 47);
            this.btnIngresa.TabIndex = 7;
            this.btnIngresa.Text = "Ingresar";
            this.btnIngresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresa.UseVisualStyleBackColor = false;
            this.btnIngresa.Click += new System.EventHandler(this.btnIngresa_Click);
            // 
            // btnCerra
            // 
            this.btnCerra.BackColor = System.Drawing.Color.Red;
            this.btnCerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerra.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCerra.IconColor = System.Drawing.Color.Black;
            this.btnCerra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerra.IconSize = 30;
            this.btnCerra.Location = new System.Drawing.Point(610, 173);
            this.btnCerra.Name = "btnCerra";
            this.btnCerra.Size = new System.Drawing.Size(117, 47);
            this.btnCerra.TabIndex = 8;
            this.btnCerra.Text = "Cerrar";
            this.btnCerra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerra.UseVisualStyleBackColor = false;
            this.btnCerra.Click += new System.EventHandler(this.btnCerra_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(822, 247);
            this.Controls.Add(this.btnCerra);
            this.Controls.Add(this.btnIngresa);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private FontAwesome.Sharp.IconButton btnIngresa;
        private FontAwesome.Sharp.IconButton btnCerra;
    }
}