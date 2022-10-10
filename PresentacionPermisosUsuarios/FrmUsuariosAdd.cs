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
    public partial class FrmUsuariosAdd : Form
    {
        ManejadorPermisos mp;
        public FrmUsuariosAdd()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
            if(FrmPermisos.usuarios.IdUsuario>0)
            {
                txtNombre.Text = FrmPermisos.usuarios.Nombre;
                txtApellidoP.Text = FrmPermisos.usuarios.ApellisoP;
                txtApellidoM.Text = FrmPermisos.usuarios.ApellidoM;
                txtFDN.Text = FrmPermisos.usuarios.FechaNacimiento;
                txtRFC.Text = FrmPermisos.usuarios.Rfc;
                txtPass.Text = FrmPermisos.usuarios.Pass; 
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.manipularUsuarios(new Usuarios(FrmPermisos.usuarios.IdUsuario,txtNombre.Text,txtApellidoP.Text
                ,txtApellidoM.Text,txtFDN.Text,txtRFC.Text,txtPass.Text));
            Close();
        }
    }
}
