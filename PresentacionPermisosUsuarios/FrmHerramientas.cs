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
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas mh;
        public static Herramientas herramientas = new Herramientas("","",0,"","",0);
        public static bool modificarU = FrmMenu.modificarU, agregar = FrmMenu.agregar,
            mostrar = FrmMenu.mostrar, eliminar = FrmMenu.eliminar, modificar = FrmMenu.modificar;
        int fila, columna;

        private void dtgHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramientas.CodigoHerramienta = dtgHerramientas.Rows[fila].Cells[0].Value.ToString();
            herramientas.Nombre = dtgHerramientas.Rows[fila].Cells[1].Value.ToString();
            herramientas.Medida = double.Parse(dtgHerramientas.Rows[fila].Cells[2].Value.ToString());
            herramientas.Marca = dtgHerramientas.Rows[fila].Cells[3].Value.ToString();
            herramientas.Descripcion = dtgHerramientas.Rows[fila].Cells[4].Value.ToString();
            switch (columna)
            {
                case 5:
                    {
                        if (modificar == false)
                            MessageBox.Show("No tienes permisos para modificar datos");
                        else
                        {
                            herramientas.Opcion = 2;
                            FrmHerramientasAdd owo = new FrmHerramientasAdd();
                            owo.ShowDialog();
                            Actualizar();
                        }
                    }
                    break;
                case 6:
                    {
                        if (eliminar == false)
                            MessageBox.Show("No tienes permisos para eliminar datos");
                        else
                        {
                            herramientas.Opcion = 3;
                            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar a este usuario", "ATENCIÓN",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rs == DialogResult.Yes)
                                mh.manipularHerramientas(herramientas);
                            Actualizar();
                        }
                    }
                    break;
            }
        }

        public static int codigo = 2;
        public FrmHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }
        void Actualizar()
        {
            mh.mostrarHerramientas(dtgHerramientas,FrmInicioSesion.idusuario,2,txtBuscar.Text);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            herramientas.Opcion = 1;
            if(codigo==2)
            {
                if (agregar == false)
                    MessageBox.Show("no tienes permisos para agregar datos nuevos");
                else
                {
                    FrmHerramientasAdd owo = new FrmHerramientasAdd();
                    owo.ShowDialog();
                    Actualizar();
                }
            }
        }
    }
}
