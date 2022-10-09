using Crud;
using Entidades;
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
    public partial class FrmHerramientasAdd : Form
    {
        ManejadorHerramientas mh;
        Graficos g;
        public FrmHerramientasAdd()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            g = new Graficos();
            if(FrmHerramientas.herramientas.Opcion==2)
            {
                txtCodigo.Text = FrmHerramientas.herramientas.CodigoHerramienta; txtCodigo.Enabled = false;
                txtDescripcion.Text = FrmHerramientas.herramientas.Descripcion;
                txtMarca.Text = FrmHerramientas.herramientas.Marca;
                txtMedida.Text = FrmHerramientas.herramientas.Medida.ToString();
                txtNombre.Text = FrmHerramientas.herramientas.Nombre;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHerramientas.herramientas.Opcion == 1)
                txtCodigo.Enabled = true;
            mh.manipularHerramientas(new Herramientas(txtCodigo.Text,txtNombre.Text,double.Parse(txtMedida.Text),
                txtDescripcion.Text,txtMarca.Text,FrmHerramientas.herramientas.Opcion));
            g.Mensaje("Herramienta guardada con éxito","Enhorabuena",MessageBoxIcon.Information);
            Close();
        }
    }
}
