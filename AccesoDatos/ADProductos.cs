using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ADProductos
    {
        Base b = new Base("localhost", "root","","agenciaautomotriz");
        public void manipularProductos(dynamic Entidad)
        {
            b.comando(string.Format("CALL manipularProductos({0},'{1}','{2}','{3}','{4}')",
                Entidad.Opcion,Entidad.CodigoBarras,Entidad.Nombre,Entidad.Descripcion,Entidad.Marca));
        }
        public DataSet mostrar(int idusuario, int codigo, string filtro)
        {
            return b.Obtener(string.Format("call mostrar({0},{1},'%{2}%')",idusuario,codigo,filtro),"producto");
        }
    }
}
