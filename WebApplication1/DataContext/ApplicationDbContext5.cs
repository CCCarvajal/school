using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyecto.DataContext
{
    public class ApplicationDbContext5 : DbContext
    {
        //realiza conexión de web .config en conectio string
        public ApplicationDbContext5() : base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<Cursos2> Cursos2 { get; set; }
        public virtual DbSet<Notasx> Notasx { get; set; }


    }
}