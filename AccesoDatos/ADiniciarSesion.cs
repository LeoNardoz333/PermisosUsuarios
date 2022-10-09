using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class ADiniciarSesion
    {
        Base b = new Base("localhost","root","","agenciaautomotriz");
        public DataSet mostrar(string usuario, string pass)
        {
            return b.Obtener(string.Format("select idUsuario, nombre, pass from usuario where nombre = '{0}' and pass = '{1}'", usuario, pass), "usuario");
        }
    }
}
