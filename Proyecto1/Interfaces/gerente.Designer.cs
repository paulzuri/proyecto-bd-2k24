namespace Interfaces
{
    partial class gerente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            this.menuAlquiler = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuTituloG = new System.Windows.Forms.MenuStrip();
            this.lblSistemaDeRentasG = new System.Windows.Forms.Label();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.AutoSize = false;
            this.menuGeneral.BackColor = System.Drawing.SystemColors.Window;
            this.menuGeneral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenedor,
            this.menuAlquiler,
            this.menuClientes,
            this.menuReportes});
            this.menuGeneral.Location = new System.Drawing.Point(0, 74);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(992, 78);
            this.menuGeneral.TabIndex = 0;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(152, 74);
            this.menuUsuarios.Text = "USUARIOS";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.AutoSize = false;
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem6,
            this.iconMenuItem7});
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 50;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(152, 74);
            this.menuMantenedor.Text = "MANTENDERO";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(178, 26);
            this.iconMenuItem6.Text = "CATEGORIAS";
            // 
            // iconMenuItem7
            // 
            this.iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem7.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem7.Name = "iconMenuItem7";
            this.iconMenuItem7.Size = new System.Drawing.Size(178, 26);
            this.iconMenuItem7.Text = "PELÍCULAS";
            // 
            // menuAlquiler
            // 
            this.menuAlquiler.AutoSize = false;
            this.menuAlquiler.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.menuAlquiler.IconColor = System.Drawing.Color.Black;
            this.menuAlquiler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAlquiler.IconSize = 50;
            this.menuAlquiler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAlquiler.Name = "menuAlquiler";
            this.menuAlquiler.Size = new System.Drawing.Size(152, 74);
            this.menuAlquiler.Text = "ALQUILER";
            this.menuAlquiler.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(152, 74);
            this.menuClientes.Text = "CLIENTES";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(152, 74);
            this.menuReportes.Text = "REPORTES";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // menuTituloG
            // 
            this.menuTituloG.AutoSize = false;
            this.menuTituloG.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTituloG.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTituloG.Location = new System.Drawing.Point(0, 0);
            this.menuTituloG.Name = "menuTituloG";
            this.menuTituloG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTituloG.Size = new System.Drawing.Size(992, 74);
            this.menuTituloG.TabIndex = 1;
            this.menuTituloG.Text = "menuStrip2";
            // 
            // lblSistemaDeRentasG
            // 
            this.lblSistemaDeRentasG.AutoSize = true;
            this.lblSistemaDeRentasG.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSistemaDeRentasG.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaDeRentasG.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSistemaDeRentasG.Location = new System.Drawing.Point(12, 18);
            this.lblSistemaDeRentasG.Name = "lblSistemaDeRentasG";
            this.lblSistemaDeRentasG.Size = new System.Drawing.Size(469, 38);
            this.lblSistemaDeRentasG.TabIndex = 2;
            this.lblSistemaDeRentasG.Text = "Sistema de Rentas (Gerente)";
            this.lblSistemaDeRentasG.Click += new System.EventHandler(this.label1_Click);
            // 
            // gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 553);
            this.Controls.Add(this.lblSistemaDeRentasG);
            this.Controls.Add(this.menuGeneral);
            this.Controls.Add(this.menuTituloG);
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "gerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGeneral;
        private System.Windows.Forms.MenuStrip menuTituloG;
        private System.Windows.Forms.Label lblSistemaDeRentasG;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem menuAlquiler;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
    }
}

