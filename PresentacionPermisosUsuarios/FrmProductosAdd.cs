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
    public partial class FrmProductosAdd : Form
    {
        ManejadorProductos mp;
        Graficos g;
        public FrmProductosAdd()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            g = new Graficos();
            if (FrmProductos.producto.Opcion == 2)
            {
                txtCodigo.Text = FrmProductos.producto.CodigoBarras; txtCodigo.Enabled = false;
                txtDescripcion.Text = FrmProductos.producto.Descripcion;
                txtMarca.Text = FrmProductos.producto.Marca;
                txtNombre.Text = FrmProductos.producto.Nombre;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProductos.producto.Opcion == 1)
                txtCodigo.Enabled = true;
            mp.manipularProductos(new Productos(txtCodigo.Text, txtNombre.Text,
                txtDescripcion.Text, txtMarca.Text, FrmProductos.producto.Opcion));
            g.Mensaje("Producto guardada con éxito", "Enhorabuena", MessageBoxIcon.Information);
            Close();
        }
    }
}
