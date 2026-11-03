using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Entidades
{
    internal class Reservas
    {
        int id;
        int idProfesor;
        int idKit;
        string CantidadKits;
        DateTime FechaInicio;
        DateTime FechaFin;
        string Motivo;
        string EstadoReserva;
    }
}
