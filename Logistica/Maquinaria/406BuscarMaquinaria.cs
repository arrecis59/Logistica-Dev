using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica.Maquinaria
{
    public partial class MantenimientoMaquinaria : Form
    {
        public MantenimientoMaquinaria()
        {
            InitializeComponent();
        }

        private void MantenimientoMaquinaria_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Maquinaria.AgregarMaquinaria agregar = new Maquinaria.AgregarMaquinaria();
            agregar.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Maquinaria.ModificarMaquinaria modificar = new Maquinaria.ModificarMaquinaria();
            modificar.Show();
        }
    }
}
