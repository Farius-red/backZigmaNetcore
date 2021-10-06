using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Productos.Api.Models;
namespace Productos.Api
{
    public class AplicationDbcontext : DbContext
    {
        public AplicationDbcontext(DbContextOptions<AplicationDbcontext> options) : base(options)
        {

        }


        public DbSet<Productos> Productos { get; set; }
    }


}