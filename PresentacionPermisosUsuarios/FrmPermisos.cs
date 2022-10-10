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
    public partial class FrmPermisos : Form
    {
        ManejadorPermisos mp;
        public static Permisos permisos = new Permisos(0,0,0,false,false,false,false,false);
        public static Usuarios usuarios = new Usuarios(0,"","","","","","");
        int fila, columna;
        public static string nombre;
        public FrmPermisos()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }
        void Actualizar()
        {
            if (cmbCambio.Text == "Permisos")
            {
                mp.mostrarPermisos(dtgPermisos, txtBuscar.Text);
                lbl1.Visible = true; lbl2.Visible = true;
            }
            else if (cmbCambio.Text == "Usuarios")
            {
                mp.mostrarUsuarios(dtgPermisos, txtBuscar.Text);
                lbl1.Visible = false; lbl2.Visible = false;
            }
        }
        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCambio.Text == "Permisos")
            {
                permisos.Opcion = 1;
                FrmPermisosAdd owo = new FrmPermisosAdd();
                owo.ShowDialog();
            }
            else if(cmbCambio.Text=="Usuarios")
            {
                usuarios.IdUsuario = -1;
                FrmUsuariosAdd uwu = new FrmUsuariosAdd();
                uwu.ShowDialog();
            }
            Actualizar();
        }

        private void dtgPermisos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }

        private void dtgPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbCambio.Text == "Permisos")
            {
                permisos._IdUsuario = int.Parse(dtgPermisos.Rows[fila].Cells[0].Value.ToString());
                nombre = dtgPermisos.Rows[fila].Cells[1].Value.ToString();
                permisos._Codigo = int.Parse(dtgPermisos.Rows[fila].Cells[2].Value.ToString());
                permisos.Agregar = bool.Parse(dtgPermisos.Rows[fila].Cells[4].Value.ToString());
                permisos.Eliminar = bool.Parse(dtgPermisos.Rows[fila].Cells[6].Value.ToString());
                permisos.Modificar = bool.Parse(dtgPermisos.Rows[fila].Cells[5].Value.ToString());
                permisos.ModificarU = bool.Parse(dtgPermisos.Rows[fila].Cells[3].Value.ToString());
                permisos.Mostrar = bool.Parse(dtgPermisos.Rows[fila].Cells[7].Value.ToString());
                switch (columna)
                {
                    case 8:
                        {
                            permisos.Opcion = 2;
                            FrmPermisosAdd owo = new FrmPermisosAdd();
                            owo.ShowDialog();
                            Actualizar();
                        }
                        break;
                    case 9:
                        {
                            permisos.Opcion = 3;
                            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar a este usuario", "ATENCIÓN",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rs == DialogResult.Yes)
                                mp.manipularPermisos(permisos);
                            Actualizar();
                        }
                        break;
                }
            }
            else if (cmbCambio.Text == "Usuarios")
            {
                usuarios.IdUsuario = int.Parse(dtgPermisos.Rows[fila].Cells[0].Value.ToString());
                usuarios.Nombre = dtgPermisos.Rows[fila].Cells[1].Value.ToString();
                usuarios.ApellisoP = dtgPermisos.Rows[fila].Cells[2].Value.ToString();
                usuarios.ApellidoM = dtgPermisos.Rows[fila].Cells[3].Value.ToString();
                usuarios.FechaNacimiento = Convert.ToDateTime(dtgPermisos.Rows[fila].Cells[4].Value).ToString("yyyy-MM-dd");
                usuarios.Rfc = dtgPermisos.Rows[fila].Cells[5].Value.ToString();
                usuarios.Pass = dtgPermisos.Rows[fila].Cells[6].Value.ToString();
                switch (columna)
                {
                    case 7:
                        {
                            FrmUsuariosAdd owo = new FrmUsuariosAdd();
                            owo.ShowDialog();
                            Actualizar();
                        }
                        break;
                    case 8:
                        {
                                mp.borrarUsuarios(usuarios);
                            Actualizar();
                        }
                        break;
                }
            }
        }

        private void cmbCambio_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
