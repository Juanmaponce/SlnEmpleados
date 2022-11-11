using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleados
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(4)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados{ get; set; }
    }
}
