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
    public class ManejadorProductos
    {
        ADProductos adp = new ADProductos();
        Graficos g = new Graficos();
        public void manipularProductos(dynamic Entidad)
        {
            adp.manipularProductos(Entidad);
        }
        public void mostrarProductos(DataGridView tabla,int idusuario, int codigo, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = adp.mostrar(idusuario, codigo, filtro).Tables["producto"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red));
        }
    }
}
