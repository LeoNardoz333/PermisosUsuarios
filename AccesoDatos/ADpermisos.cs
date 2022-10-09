using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ADpermisos
    {
        //opcion,__idUsuario,__codigo,_modificarU,_agregar,_modificar,_eliminar,_mostrar
        Base b = new Base("localhost", "root", "", "agenciaautomotriz");
        public void manipularPermisos (dynamic Entidad)
        {
            b.comando(string.Format("call manipularPermisos({0},{1},{2},{3},{4},{5},{6},{7})",Entidad.Opcion,Entidad._IdUsuario,Entidad._Codigo,
                Entidad.ModificarU,Entidad.Agregar,Entidad.Modificar,Entidad.Eliminar,Entidad.Mostrar));
        }

        public DataSet mostrarUsuarios(string filtro)
        {
            return b.Obtener(string.Format("call mostrarUsuarios('%{0}%')",filtro),"usuario");
        }

        public DataSet mostrarPermisos(string filtro)
        {
            return b.Obtener(string.Format("call mostrarPermisos('%{0}%')",filtro),"permisos");
        }
        public DataSet extraerPermisos(int idUsuario)
        {
            return b.Obtener(string.Format("select * from permisos where _idUsuario={0}", idUsuario), "permisos");
        }
    }
}
