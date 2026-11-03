using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Entidades
{
    internal class MatriculasEstudiantes //prueba
    {
        int id;
        int Estudianteid;
        int profesorid;
        int fasecurricularid;

        DateTime FechaInicioEstudiante;
        DateTime FechaFinEstudiante;
        DateTime FechaInicioCurso;
        DateTime FechaFinOriginal;
        DateTime FechaFinPrevista;
        string Observacionextension;
        string DiaSemana;
        TimeOnly HoraInicio;
        TimeOnly HoraFin;
        string EstadoMatricula; //Activo, Inactivo, Finalizado, etc..

    }
}
