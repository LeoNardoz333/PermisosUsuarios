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
        Base b = new Base("localhost","root","","agenciaautomotriz");
        public void Agregar(dynamic Entidad)
        {
            b.comando(string.Format("call manipularPermisos({0},{1},{2},{4},{5},{6},{7},{8})",Entidad.Opcion,Entidad._IdUsuario,Entidad.ModificarU,
                Entidad.Agregar,Entidad.Modificar,Entidad.Eliminar,Entidad.Mostrar));
        }

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("call manipularPermisos({0},{1},{2},{4},{5},{6},{7},{8})", Entidad.Opcion, Entidad._IdUsuario, Entidad.ModificarU,
                Entidad.Agregar, Entidad.Modificar, Entidad.Eliminar, Entidad.Mostrar));
        }

        public DataSet mostrarUsuarios(string filtro)
        {
            return b.Obtener(string.Format("call mostrarUsuarios()",filtro),"usuario");
        }

        public DataSet mostrarPermisos(int idUsuario)
        {
            return b.Obtener(string.Format("select * from permisos where _idUsuario={0}",idUsuario),"permisos");
        }
    }
}
