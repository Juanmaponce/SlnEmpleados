using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Empleado : Persona
    {
        public Empleado(string id, string nombre, string apellido, int legajo) : base(id, nombre, apellido)
        {
            Legajo = legajo;
        }
        public int Legajo { get; set; }

        public Departamento Departamento { get; set; }
    }
}
