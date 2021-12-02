using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class Estudiante
    {
        public int ID { get; set; } 
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carnet { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
    }
}
