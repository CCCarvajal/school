using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyecto.DataContext
{
    public class ApplicationDbContext7 : DbContext
    {
        public ApplicationDbContext7() : base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<FileModels> SubirArchivo { get; set; }
    }
}