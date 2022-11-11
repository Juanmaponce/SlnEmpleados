using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    public class Departamento
    {
        public Departamento(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados{ get; set; }
    }
}
