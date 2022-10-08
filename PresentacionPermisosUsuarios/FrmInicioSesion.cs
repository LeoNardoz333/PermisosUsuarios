using AccesoDatos;
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
    public partial class FrmInicioSesion : Form
    {
        ADiniciarSesion adis;
        public FrmInicioSesion()
        {
            InitializeComponent();
            adis = new ADiniciarSesion();
        }
        string usuario, contra;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var ds = adis.mostrar(txtUsuario.Text,txtPass.Text);
            var dt = new DataTable();
            dt = ds.Tables[0];
            try
            {
                usuario = dt.Rows[0]["nombre"].ToString();
                contra = dt.Rows[0]["pass"].ToString();
                if (usuario == txtUsuario.Text && contra == txtPass.Text)
                {
                    MessageBox.Show("Bienvenido owo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Uno o más campos incorrectos");
            }
        }
    }
}
