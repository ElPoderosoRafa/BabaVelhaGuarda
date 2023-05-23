using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabaVelhaGuardaDigital.Models.Participantes;
using BabaVelhaGuardaDigital.Models.Usuarios;

namespace BabaVelhaGuardaDigital.Models
{
    public class BabaVelhaGuardaContext : DbContext
    {
        public BabaVelhaGuardaContext(DbContextOptions options) : base(options) { }

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
