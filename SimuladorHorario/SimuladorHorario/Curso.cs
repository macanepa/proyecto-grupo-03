﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Curso
    {
        string nombre;
        string profesor;
        List<Evento> horarios;

        public Curso(string nombre, string profesor, List<Evento> horarios)
        {
            this.nombre = nombre;
            this.profesor = profesor;
            this.horarios = horarios;
        }

    }
}