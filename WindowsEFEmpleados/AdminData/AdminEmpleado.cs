using LibreriaEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEmpleados.Models;
using static System.Windows.Forms.AxHost;

namespace WindowsEFEmpleados.AdminData
{
    public class AdminEmpleado
    {
        DBEmpleadosContext context = new DBEmpleadosContext();
        public List<Empleado> Lista()
        {
            List<Empleado> lista = context.Empleados.ToList();
            return lista;
        }
        public int Nuevo(Empleado empleado)
        {
            context.Empleados.Add(empleado);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
    }
}
