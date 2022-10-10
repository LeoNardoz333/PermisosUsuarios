using AccesoDatos;
using Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorPermisos
    {
        ADpermisos adp = new ADpermisos();
        Graficos g = new Graficos();
        public void evaluarPermisos(int codigo, bool modificarU, bool agregar,
            bool modificar, bool eliminar, bool mostrar, ToolStripButton usuarios, ToolStripButton producto, ToolStripButton herramientas)
        {
            if (codigo == 1)
            {
                if (modificarU == true)
                    usuarios.Enabled = true;
                if (((agregar == true || modificar == true || eliminar == true) && (mostrar==true)) 
                    || (mostrar == true && (agregar == false || modificar == false || eliminar == false)))
                    producto.Enabled = true;
                /*if (mostrar == true)
                    producto.Enabled = true;*/
            }
            if (codigo == 2)
            {
                if (modificarU == true)
                    usuarios.Enabled = true;
                if (((agregar == true || modificar == true || eliminar == true) && (mostrar==true))
                    || (mostrar == true && (agregar == false || modificar == false || eliminar == false)))
                    herramientas.Enabled = true;
            }
        }
        public void manipularPermisos(dynamic Entidad)
        {
            adp.manipularPermisos(Entidad);
        }
        public void mostrarPermisos(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = adp.mostrarPermisos(filtro).Tables["permisos"];
            tabla.Columns.Insert(8, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(9, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        public void extraerUsuarios(ComboBox caja)
        {
            caja.DataSource = adp.mostrarUsuarios("").Tables["usuario"];
            caja.DisplayMember = "nombre";
            caja.ValueMember = "idUsuario";
        }
        public void mostrarUsuarios(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = adp.mostrarUsuarios(filtro).Tables["usuario"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
        }
        public void manipularUsuarios(dynamic Entidad)
        {
            adp.manipularUsuarios(Entidad);
            g.Mensaje("Se guardó al usuario correctamente","Enhorabuena",MessageBoxIcon.Information);
        }
        public void borrarUsuarios(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar a este usuario", "ATENCIÓN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                adp.borrarUsuarios(Entidad);
        }
    }
}
