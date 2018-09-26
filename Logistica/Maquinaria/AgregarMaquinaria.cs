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
    public partial class AgregarMaquinaria : Form
    {
        public AgregarMaquinaria()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Maquinaria.ModificarMaquinaria modificar = new Maquinaria.ModificarMaquinaria();
            modificar.Show();
        }
    }
}
