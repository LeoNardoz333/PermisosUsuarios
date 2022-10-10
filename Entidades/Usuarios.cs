using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string nombre, string apellisoP, string apellidoM, string fechaNacimiento, string rfc, string pass)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            ApellisoP = apellisoP;
            ApellidoM = apellidoM;
            FechaNacimiento = fechaNacimiento;
            Rfc = rfc;
            Pass = pass;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellisoP { get; set; }
        public string ApellidoM { get; set; }
        public string FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Pass { get; set; }
    }
}
