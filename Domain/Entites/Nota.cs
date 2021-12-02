using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class Nota
    {
        public int Sistematico { get; set; }
        public int PrimParcial { get; set; }
        public int SegParcial { get; set; }
        public int Tarea { get; set; }
        public int NotaFinal { get; set; }
        public Asignatura Asignatura { get; set; }
    }
}
