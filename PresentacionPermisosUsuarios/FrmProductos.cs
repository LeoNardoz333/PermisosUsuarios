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
        ADpermisos adp;
        public static Productos producto = new Productos("","","","",0);
        public static bool modificarU, agregar, mostrar, eliminar, modificar;
        public static int codigo = 1;
        int fila, columna;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            adp = new ADpermisos();
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Actualizar();
            var ds = adp.permisosTablas(FrmInicioSesion.idusuario, codigo);
            var dt = new DataTable();
            dt = ds.Tables[0];
            modificarU = bool.Parse(dt.Rows[0]["modificarUsuarios"].ToString());
            agregar = bool.Parse(dt.Rows[0]["agregar"].ToString());
            mostrar = bool.Parse(dt.Rows[0]["mostrar"].ToString());
            eliminar = bool.Parse(dt.Rows[0]["eliminar"].ToString());
            modificar = bool.Parse(dt.Rows[0]["modificar"].ToString());
            codigo = int.Parse(dt.Rows[0]["_codigo"].ToString());
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.CodigoBarras = dtgProductos.Rows[fila].Cells[0].Value.ToString();
            producto.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            producto.Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            producto.Marca = dtgProductos.Rows[fila].Cells[3].Value.ToString();
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
                            Actualizar();
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
                    Actualizar();
                }
            }
        }
    }
}
