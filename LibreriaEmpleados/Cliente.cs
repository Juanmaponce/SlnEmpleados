using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Cliente:Persona
    {
        public Cliente(string id, string nombre, string apellido, int cuil, int telefono):base(id,nombre,apellido)
        {
            Cuil = cuil;
            Telefono = telefono;
        }

        public int Cuil { get; set; }
        public int Telefono { get; set; }
    }
}
