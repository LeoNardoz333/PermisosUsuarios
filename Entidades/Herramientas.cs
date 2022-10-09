using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramientas
    {
        public Herramientas(string codigoHerramienta, string nombre, double medida, string descripcion, string marca, int opcion)
        {
            CodigoHerramienta = codigoHerramienta;
            Nombre = nombre;
            Medida = medida;
            Descripcion = descripcion;
            Marca = marca;
            Opcion = opcion;
        }

        public string CodigoHerramienta { get; set; }
        public string Nombre { get; set; }
        public double Medida { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Opcion { get; set; }
    }
}
