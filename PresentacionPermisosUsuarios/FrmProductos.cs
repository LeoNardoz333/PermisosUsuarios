using AccesoDatos;
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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        ADpermisos adpe;
        public static Productos producto = new Productos("","","","",0);
        public static bool modificarU=FrmMenu.modificarU, agregar=FrmMenu.agregar,
            mostrar=FrmMenu.mostrar, eliminar=FrmMenu.eliminar, modificar=FrmMenu.modificar;
        public static int codigo = 1;
        int fila, columna;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            adpe = new ADpermisos();
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (columna)
            {
                case 4:
                    {
                        if (modificar == false)
                            MessageBox.Show("No tienes permisos para modificar datos");
                        else
                        {

                            producto.Opcion = 2;
                            FrmProductosAdd owo = new FrmProductosAdd();
                            owo.ShowDialog();
                        }
                    }
                    break;
                case 5:
                    {
                        if (eliminar == false)
                            MessageBox.Show("No tienes permisos para eliminar datos");
                        else
                        {
                            producto.Opcion = 3;
                            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar a este usuario", "ATENCIÓN",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rs == DialogResult.Yes)
                                mp.manipularProductos(producto);
                            Actualizar();
                        }
                    }
                    break;
            }
        }

        void Actualizar()
        {
            mp.mostrarProductos(dtgProductos, FrmInicioSesion.idusuario, 1, txtBuscar.Text);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.Opcion = 1;
            if (codigo == 1)
            {
                if (agregar == false)
                    MessageBox.Show("No tienes permisos para agregar nuevos datos");
                else
                {
                    FrmProductosAdd owo = new FrmProductosAdd();
                    owo.ShowDialog();
                }
            }
        }
    }
}
