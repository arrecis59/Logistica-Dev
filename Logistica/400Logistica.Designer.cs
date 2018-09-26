namespace Logistica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matenimientoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMaquinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesAProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTransporteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1139, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarAplicacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // cerrarAplicacionesToolStripMenuItem
            // 
            this.cerrarAplicacionesToolStripMenuItem.Name = "cerrarAplicacionesToolStripMenuItem";
            this.cerrarAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.cerrarAplicacionesToolStripMenuItem.Text = "Cerrar Aplicaciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logisticaToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.vehiculosToolStripMenuItem});
            this.catalogosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            this.catalogosToolStripMenuItem.Click += new System.EventHandler(this.catalogosToolStripMenuItem_Click);
            // 
            // logisticaToolStripMenuItem
            // 
            this.logisticaToolStripMenuItem.Name = "logisticaToolStripMenuItem";
            this.logisticaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.logisticaToolStripMenuItem.Text = "Inventarios";
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matenimientoProductoToolStripMenuItem,
            this.ordenDeTransporteToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // matenimientoProductoToolStripMenuItem
            // 
            this.matenimientoProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeProductosToolStripMenuItem,
            this.mantenimientoDeVehiculosToolStripMenuItem,
            this.mantenimientoDeMaquinariaToolStripMenuItem});
            this.matenimientoProductoToolStripMenuItem.Name = "matenimientoProductoToolStripMenuItem";
            this.matenimientoProductoToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.matenimientoProductoToolStripMenuItem.Text = "Matenimientos";
            // 
            // mantenimientoDeProductosToolStripMenuItem
            // 
            this.mantenimientoDeProductosToolStripMenuItem.Name = "mantenimientoDeProductosToolStripMenuItem";
            this.mantenimientoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.mantenimientoDeProductosToolStripMenuItem.Text = "Mantenimiento de productos";
            this.mantenimientoDeProductosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeProductosToolStripMenuItem_Click);
            // 
            // mantenimientoDeVehiculosToolStripMenuItem
            // 
            this.mantenimientoDeVehiculosToolStripMenuItem.Name = "mantenimientoDeVehiculosToolStripMenuItem";
            this.mantenimientoDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.mantenimientoDeVehiculosToolStripMenuItem.Text = "Mantenimiento de vehiculos";
            this.mantenimientoDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeVehiculosToolStripMenuItem_Click);
            // 
            // mantenimientoDeMaquinariaToolStripMenuItem
            // 
            this.mantenimientoDeMaquinariaToolStripMenuItem.Name = "mantenimientoDeMaquinariaToolStripMenuItem";
            this.mantenimientoDeMaquinariaToolStripMenuItem.Size = new System.Drawing.Size(320, 26);
            this.mantenimientoDeMaquinariaToolStripMenuItem.Text = "Mantenimiento de Maquinaria";
            this.mantenimientoDeMaquinariaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeMaquinariaToolStripMenuItem_Click);
            // 
            // ordenDeTransporteToolStripMenuItem
            // 
            this.ordenDeTransporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesAProduccionToolStripMenuItem,
            this.ordenDeTransporteToolStripMenuItem1});
            this.ordenDeTransporteToolStripMenuItem.Name = "ordenDeTransporteToolStripMenuItem";
            this.ordenDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.ordenDeTransporteToolStripMenuItem.Text = "Ordenes";
            // 
            // ordenesAProduccionToolStripMenuItem
            // 
            this.ordenesAProduccionToolStripMenuItem.Name = "ordenesAProduccionToolStripMenuItem";
            this.ordenesAProduccionToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.ordenesAProduccionToolStripMenuItem.Text = "Orden a produccion";
            // 
            // ordenDeTransporteToolStripMenuItem1
            // 
            this.ordenDeTransporteToolStripMenuItem1.Name = "ordenDeTransporteToolStripMenuItem1";
            this.ordenDeTransporteToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.ordenDeTransporteToolStripMenuItem1.Text = "Orden de transporte";
            this.ordenDeTransporteToolStripMenuItem1.Click += new System.EventHandler(this.ordenDeTransporteToolStripMenuItem1_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeBitacoraToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeBitacoraToolStripMenuItem
            // 
            this.reportesDeBitacoraToolStripMenuItem.Name = "reportesDeBitacoraToolStripMenuItem";
            this.reportesDeBitacoraToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.reportesDeBitacoraToolStripMenuItem.Text = "Reportes de Inventarios";
            this.reportesDeBitacoraToolStripMenuItem.Click += new System.EventHandler(this.reportesDeBitacoraToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeServidorToolStripMenuItem});
            this.herramientasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(126, 25);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // cambioDeServidorToolStripMenuItem
            // 
            this.cambioDeServidorToolStripMenuItem.Name = "cambioDeServidorToolStripMenuItem";
            this.cambioDeServidorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.cambioDeServidorToolStripMenuItem.Text = "Cambio de servidor";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(168)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(1139, 701);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "400_Logistica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeBitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeServidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matenimientoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMaquinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTransporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesAProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTransporteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
    }
}

