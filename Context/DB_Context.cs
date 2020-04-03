using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMaestroDetalle.Models;

namespace ApiMaestroDetalle.Context
{
    public class DB_Context : DbContext
    { 
        public DB_Context(DbContextOptions<DB_Context> options)
            :base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }  
    }
}
