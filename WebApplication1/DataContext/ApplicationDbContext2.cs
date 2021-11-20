using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proyecto.DataContext
{
    public class ApplicationDbContext2 : DbContext
    {
        //realiza conexión de web .config en conectio string
        public ApplicationDbContext2() : base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<AdministradorModels> RegistroEstudiante { get; set; }
        public virtual DbSet<RegistroAcudiente> RegistroAcudiente { get; set; }
        public virtual DbSet<RegistroDocente> RegistroDocente { get; set; }
        public virtual DbSet<RegistroAdministrador> RegistroAdministrador { get; set; }
        public virtual DbSet<DocenteModels> CursosDocente { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<CursosModels> Cursos { get; set; }
        public virtual DbSet<Notasx> Notasx { get; set; }


        //relacion 
        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Union>().HasRequired(x => x.DocumentoUnionDocente);
            base.OnModelCreating(modelBuilder);

        }*/
        // public virtual DbSet<Union> Union { get; set; }
        //public virtual Tuple<CursosModels,RegistroDocente> Tablas { get; set; }


    }
}
