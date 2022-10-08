using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionPermisosUsuarios
{
    public partial class FrmPermisos : Form
    {
        ManejadorPermisos mp;
        public FrmPermisos()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }
        void Actualizar()
        {
            mp.mostrarPermisos(dtgPermisos,txtBuscar.Text);
        }
        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
