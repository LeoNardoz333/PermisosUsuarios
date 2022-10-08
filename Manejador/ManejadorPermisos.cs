using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorPermisos
    {
        public void evaluarPermisos(int codigo, bool modificarU, bool agregar,
            bool modificar, bool eliminar, bool mostrar, ToolStripButton usuarios, ToolStripButton producto, ToolStripButton herramientas)
        {
            if (codigo == 1)
            {
                if (modificarU != true)
                    usuarios.Enabled = false;
                if (agregar != true || modificar != true || eliminar != true || mostrar != true)
                    producto.Enabled = false;
            }
            if (codigo == 2)
            {
                if (modificarU != true)
                    usuarios.Enabled = false;
                if (agregar != true || modificar != true || eliminar != true || mostrar != true)
                    herramientas.Enabled = false;
            }
        }
    }
}
