using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Entidades
{
    internal class Prestamos
    {
        int id;
        int Profesorid;
        int Kitid;
        DateTime FechaPrestamo;
        DateTime FechaDevolucionEstimada;
        DateTime FechaDevolucionReal;
        string Estado; //Encurso, Devuelto, atrasado
    }
}
