using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final_Taller_de_Programacion
{
    public class AgendaContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Telefono> Telefonos { get; set; }
    }
}
