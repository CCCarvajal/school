using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyecto.DataContext
{
    public class ApplicationDbContext4 : DbContext
    {
        //realiza conexión de web .config en conectio string
        public ApplicationDbContext4() : base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<DocumentosDocentes> Documento { get; set; }
    }
}