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
    public partial class FrmPermisosAdd : Form
    {
        ManejadorPermisos mp;
        Graficos g;
        public static int codigo;
        public FrmPermisosAdd()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
            g = new Graficos();

            mp.extraerUsuarios(cmbIdUsuario);
            if(FrmPermisos.permisos.Opcion==2)
            {
                if(FrmPermisos.permisos._Codigo==1)
                {
                    cmbCodigo.Text = "Productos";
                    codigo = 1;
                }
                else if (FrmPermisos.permisos._Codigo == 2)
                {
                    cmbCodigo.Text = "Herramientas";
                    codigo = 2;
                }
                cmbIdUsuario.Text = FrmPermisos.nombre;
                cmbAgregar.Text = FrmPermisos.permisos.Agregar.ToString();
                cmbEliminar.Text = FrmPermisos.permisos.Eliminar.ToString();
                cmbModificar.Text = FrmPermisos.permisos.Modificar.ToString();
                cmbMostrar.Text = FrmPermisos.permisos.Mostrar.ToString();
                cmbModificarU.Text = FrmPermisos.permisos.ModificarU.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.Text == "Productos")
                codigo = 1;
            else if (cmbCodigo.Text == "Herramientas")
                codigo = 2;
            mp.manipularPermisos(new Permisos(FrmPermisos.permisos.Opcion,
                int.Parse(cmbIdUsuario.SelectedValue.ToString()),codigo,bool.Parse(cmbModificarU.Text), 
                bool.Parse(cmbAgregar.Text), bool.Parse(cmbModificar.Text), bool.Parse(cmbEliminar.Text), 
                bool.Parse(cmbMostrar.Text)));
            g.Mensaje("Usuario guardado correctamente","Enhorabuena",MessageBoxIcon.Information);
            Close();
        }
    }
}
