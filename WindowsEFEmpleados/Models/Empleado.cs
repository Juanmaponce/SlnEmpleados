using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    [Table("Empleado")]
    public class Empleado 
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(4)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }

        public string IdDepartamento { get; set; }

        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }
    }
}
