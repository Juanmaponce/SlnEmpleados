using LibreriaEmpleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsEFEmpleados.AdminData;
using static System.Windows.Forms.AxHost;

namespace WindowsEFEmpleados
{
    public partial class Form1 : Form
    {
        AdminEmpleado adminEmpleado = new AdminEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = adminEmpleado.Lista();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           Empleado empleado = new Empleado() {Nombre = "Juan" Apellido = "Perez", Id = "1111", Legajo = 2040 };
           int filasAfectadas = adminEmpleado.Nuevo(empleado);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("OK");
            }
        }
    }
}
