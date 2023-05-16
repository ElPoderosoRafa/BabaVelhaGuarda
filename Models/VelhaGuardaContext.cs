using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabaVelhaGuardaDigital.Models
{
    public class VelhaGuardaContext : DbContext
    {
        public VelhaGuardaContext(DbContextOptions<VelhaGuardaContext> options) : base(options)
        {
        }
  

    }
}
