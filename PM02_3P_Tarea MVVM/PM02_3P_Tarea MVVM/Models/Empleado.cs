using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace PM02_3P_Tarea_MVVM.Models
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int IdEmp { get; set; }

        [MaxLength(500)]
        public String nombre { get; set; }

        [MaxLength(500)]
        public String apellido { get; set; }

        public int edad { get; set; }

        [MaxLength(500)]
        public String direccion { get; set; }

        [MaxLength(500)]
        public String puesto { get; set; }
    }
}
