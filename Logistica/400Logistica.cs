using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesDeBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos.Vehiculo vehiculo = new Vehiculos.Vehiculo();
            vehiculo.Show();
        }

        private void ordenDeTransporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrdenTransporte orden = new OrdenTransporte();
            orden.Show();
        }

        private void mantenimientoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos._409MantenimientoVehiculo vehiculo = new Vehiculos._409MantenimientoVehiculo();
            vehiculo.Show();
        }

        private void mantenimientoDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquinaria.MantenimientoMaquinaria maquinaria = new Maquinaria.MantenimientoMaquinaria();
            maquinaria.Show();           
        }

        private void mantenimientoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto.MantenimientoProducto producto = new Producto.MantenimientoProducto();
            producto.Show();
        }
    }
}
