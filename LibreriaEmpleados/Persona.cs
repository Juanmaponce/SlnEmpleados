using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public abstract class Persona
    {
        public Persona(string id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
