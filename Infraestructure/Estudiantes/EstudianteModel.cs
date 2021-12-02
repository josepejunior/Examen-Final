using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Estudiantes
{
    public class EstudianteModel
    {
        private Estudiante[] estudiantes;

        #region CRUD

        public void Create(Estudiante e)
        {
            Add(e, ref estudiantes);
        }

        public Estudiante[] FindAll()
        {
            return estudiantes;
        }
        #endregion

        #region Queries

        #endregion


        #region Private
        #endregion
    }
}
