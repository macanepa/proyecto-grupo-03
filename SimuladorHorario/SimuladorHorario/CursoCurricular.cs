﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class CursoCurricular:Curso
    {
        string nrc;
        int creditos;
        List<CursoCurricular> cursosPreRequisito;
        string carrera;
        List<Evento> eventosCurso;

        public CursoCurricular(string nrc, int creditos,
            List<CursoCurricular> cursosPreRequisito, string carrera,
            List<Evento> eventosCurso, string nombre, string profesor,
            List<Evento> horarios):base(nombre,profesor,horarios)
        {
            this.nrc = nrc;
            this.creditos = creditos;
            this.cursosPreRequisito = cursosPreRequisito;
            this.carrera = carrera;
            this.eventosCurso = eventosCurso;
        }

    }
}