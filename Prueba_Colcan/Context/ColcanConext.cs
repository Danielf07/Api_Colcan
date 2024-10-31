using Microsoft.EntityFrameworkCore;
using Prueba_Colcan.Models;

namespace Prueba_Colcan.Context
{
    public class ColcanConext: DbContext
    {
        public ColcanConext(DbContextOptions<ColcanConext> options): base(options)
        {
            
        }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}
