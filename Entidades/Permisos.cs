using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        public Permisos(int opcion, int idUsuario, int codigo, bool modificarU, bool agregar, bool modificar, bool eliminar, bool mostrar)
        {
            Opcion = opcion;
            _IdUsuario = idUsuario;
            _Codigo = codigo;
            ModificarU = modificarU;
            Agregar = agregar;
            Modificar = modificar;
            Eliminar = eliminar;
            Mostrar = mostrar;
        }

        //opcion,__idUsuario,__codigo,_modificarU,_agregar,_modificar,_eliminar,_mostrar
        public int Opcion { get; set; }
        public int _IdUsuario { get; set; }
        public int _Codigo { get; set; }
        public bool ModificarU { get; set; }
        public bool Agregar { get; set; }
        public bool Modificar { get; set; }
        public bool Eliminar { get; set; }
        public bool Mostrar { get; set; }
    }
}
