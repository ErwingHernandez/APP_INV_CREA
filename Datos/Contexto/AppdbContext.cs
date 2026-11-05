using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Datos.Entidades;

namespace Datos.Contexto
{
    class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options) : base(options)
		{
		}

		public DbSet<Profesores> Profesores { get; set; }
	}
}
