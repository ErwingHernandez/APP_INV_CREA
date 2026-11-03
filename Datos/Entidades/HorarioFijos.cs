using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Entidades
{
    internal class HorarioFijos
    {
        int id;
        int ProfesorId;
        int Tipokitid;
        int DiaSemana;
        TimeOnly HoraInicio;
        TimeOnly HoraFin;
        int CantidadKits;
        string NombreGrupo;
    }
}
