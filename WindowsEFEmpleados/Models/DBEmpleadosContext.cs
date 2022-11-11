using LibreriaEmpleados;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEmpleados.Models
{
    public class DBEmpleadosContext:DbContext
    {
        public DBEmpleadosContext() : base("Data Source=.;Initial Catalog=DBEmpleados;Integrated Security=True") { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
