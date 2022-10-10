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
        public void manipularUsuarios(dynamic Entidad)
        {
            b.comando(string.Format("CALL manipularUsuarios({0},'{1}','{2}','{3}','{4}','{5}','{6}')",Entidad.IdUsuario,
                Entidad.Nombre,Entidad.ApellisoP,Entidad.ApellidoM,Entidad.FechaNacimiento,Entidad.Rfc,Entidad.Pass));
        }
        public void borrarUsuarios(dynamic Entidad)
        {
            b.comando(string.Format("CALL borrarUsuarios({0})",Entidad.IdUsuario));
        }
        public DataSet mostrarPermisos(string filtro)
        {
            return b.Obtener(string.Format("call mostrarPermisos('%{0}%')",filtro),"permisos");
        }
        public DataSet extraerPermisos(int idUsuario)
        {
            return b.Obtener(string.Format("select * from permisos where _idUsuario={0}", idUsuario), "permisos");
        }
        public DataSet permisosTablas(int idUsuario, int codigo)
        {
            return b.Obtener(string.Format("select * from permisos where _idUsuario={0} and _codigo = {1}", idUsuario,codigo), "permisos");
        }
    }
}
