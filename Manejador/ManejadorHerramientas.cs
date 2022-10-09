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
    public class ManejadorHerramientas
    {
        ADHerramientas adh = new ADHerramientas();
        Graficos g = new Graficos();
        public void manipularHerramientas(dynamic Entidad)
        {
            adh.manipularHerramientas(Entidad);
        }
        public void mostrarHerramientas(DataGridView tabla, int idusuario, int codigo, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = adh.mostrar(idusuario, codigo, filtro).Tables["herramientas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
        }
    }
}
