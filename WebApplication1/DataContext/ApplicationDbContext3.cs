using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static proyecto.Models.CursosModels2;

namespace proyecto.DataContext
{
    public class ApplicationDbContext3 : DbContext
    {
        //realiza conexión de web .config en conectio string
        public ApplicationDbContext3() : base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<DocumentosDocentes> Documento { get; set; }


    }
}