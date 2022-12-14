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
    public partial class FrmMenu : Form
    {
        ADpermisos adp;
        ManejadorPermisos mp;
        public static bool modificarU, agregar, mostrar, eliminar, modificar;
        public static int _codigo;

        private void optHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas umu = new FrmHerramientas();
            umu.ShowDialog();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optProductos_Click(object sender, EventArgs e)
        {
            FrmProductos uwu = new FrmProductos();
            uwu.ShowDialog();
        }

        private void optPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos owo = new FrmPermisos();
            owo.ShowDialog();
        }

        public FrmMenu()
        {
            InitializeComponent();
            adp = new ADpermisos();
            mp = new ManejadorPermisos();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            var ds = adp.extraerPermisos(FrmInicioSesion.idusuario);
            var dt = new DataTable();
            dt = ds.Tables[0];
            optHerramientas.Enabled = false;
            optPermisos.Enabled = false;
            optProductos.Enabled = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                modificarU = bool.Parse(dt.Rows[i]["modificarUsuarios"].ToString());
                agregar = bool.Parse(dt.Rows[i]["agregar"].ToString());
                mostrar = bool.Parse(dt.Rows[i]["mostrar"].ToString());
                eliminar = bool.Parse(dt.Rows[i]["eliminar"].ToString());
                modificar = bool.Parse(dt.Rows[i]["modificar"].ToString());
                _codigo = int.Parse(dt.Rows[i]["_codigo"].ToString());
                mp.evaluarPermisos(_codigo,modificarU,agregar,modificar,
                    eliminar,mostrar,optPermisos,optProductos,optHerramientas);
            }
        }
    }
}
