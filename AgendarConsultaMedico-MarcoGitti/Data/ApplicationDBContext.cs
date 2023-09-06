using AgendarConsultaMedico_MarcoGitti.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendarConsultaMedico_MarcoGitti.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<ConsultaModel>Consultas { get; set; }
    }
}