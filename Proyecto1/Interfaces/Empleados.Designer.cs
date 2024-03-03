namespace Interfaces
{
    partial class Empleados
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
            this.menuGeneralE = new System.Windows.Forms.MenuStrip();
            this.menuTituloE = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuRentasE = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedorE = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientesE = new FontAwesome.Sharp.IconMenuItem();
            this.menuGeneralE.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneralE
            // 
            this.menuGeneralE.AutoSize = false;
            this.menuGeneralE.BackColor = System.Drawing.SystemColors.Window;
            this.menuGeneralE.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGeneralE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientesE,
            this.menuMantenedorE,
            this.menuRentasE});
            this.menuGeneralE.Location = new System.Drawing.Point(0, 74);
            this.menuGeneralE.Name = "menuGeneralE";
            this.menuGeneralE.Size = new System.Drawing.Size(992, 87);
            this.menuGeneralE.TabIndex = 0;
            this.menuGeneralE.Text = "menuStrip1";
            // 
            // menuTituloE
            // 
            this.menuTituloE.AutoSize = false;
            this.menuTituloE.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTituloE.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTituloE.Location = new System.Drawing.Point(0, 0);
            this.menuTituloE.Name = "menuTituloE";
            this.menuTituloE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTituloE.Size = new System.Drawing.Size(992, 74);
            this.menuTituloE.TabIndex = 1;
            this.menuTituloE.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema De Renta (Empleados)";
            // 
            // menuRentasE
            // 
            this.menuRentasE.AutoSize = false;
            this.menuRentasE.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.menuRentasE.IconColor = System.Drawing.Color.Black;
            this.menuRentasE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuRentasE.IconSize = 50;
            this.menuRentasE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRentasE.Name = "menuRentasE";
            this.menuRentasE.Size = new System.Drawing.Size(152, 74);
            this.menuRentasE.Text = "RENTAS";
            this.menuRentasE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.iconMenuItem1.Text = "CATEGORIAS";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.iconMenuItem3.Text = "PELÍCULAS";
            // 
            // menuMantenedorE
            // 
            this.menuMantenedorE.AutoSize = false;
            this.menuMantenedorE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem3});
            this.menuMantenedorE.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedorE.IconColor = System.Drawing.Color.Black;
            this.menuMantenedorE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedorE.IconSize = 50;
            this.menuMantenedorE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedorE.Name = "menuMantenedorE";
            this.menuMantenedorE.Size = new System.Drawing.Size(152, 74);
            this.menuMantenedorE.Text = "MANTENEDOR";
            this.menuMantenedorE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuClientesE
            // 
            this.menuClientesE.AutoSize = false;
            this.menuClientesE.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientesE.IconColor = System.Drawing.Color.Black;
            this.menuClientesE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientesE.IconSize = 50;
            this.menuClientesE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientesE.Name = "menuClientesE";
            this.menuClientesE.Size = new System.Drawing.Size(152, 74);
            this.menuClientesE.Text = "CLIENTES";
            this.menuClientesE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuGeneralE);
            this.Controls.Add(this.menuTituloE);
            this.MainMenuStrip = this.menuGeneralE;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.menuGeneralE.ResumeLayout(false);
            this.menuGeneralE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGeneralE;
        private System.Windows.Forms.MenuStrip menuTituloE;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuClientesE;
        private FontAwesome.Sharp.IconMenuItem menuMantenedorE;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem menuRentasE;
    }
}