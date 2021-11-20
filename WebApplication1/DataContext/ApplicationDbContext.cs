using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using proyecto.Models;
using Npgsql;

namespace proyecto.DataContext
{
    //se hereda de DbContext 
    public class ApplicationDbContext : DbContext
    {
        //realiza conexión de web .config en conectio string
        public ApplicationDbContext(): base(nameOrConnectionString: "Myconnection")
        {

        }
        //
        public virtual DbSet<InicioModels> Empobj { get; set; }
        public virtual DbSet<registroEstudiante> Estudiante { get; set; }
        public virtual DbSet<registroAdministrador> Administrador { get; set; }


    }
}