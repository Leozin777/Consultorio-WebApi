using Consultorio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Consultorio_WebApi.Context
{
    public class ConsultorioContext :DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> opts) : base(opts)
        { }

        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
