using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static proyecto.Models.AñadirNotasModels;

namespace proyecto.DataContext
{
    public class ApplicationDbContext6:DbContext
    {
        public ApplicationDbContext6() : base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<SubirNotas> SubirNotas { get; set; }
    }
}