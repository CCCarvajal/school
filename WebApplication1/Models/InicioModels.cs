using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    //Tabla que se va a utilizar
    [Table("docente", Schema = "public")]
    public class InicioModels
    {

        
        public String ApellidoUnoDocente { get; set; }
        public String ApellidoDosDocente { get; set; }
        public String NombreUnoDocente { get; set; }
        public String NombreDosDocente { get; set; }
        public Char GeneroDocente { get; set; }
        public String TipoDocumentoDocente { get; set; }
        [Key]
        public int DocumentoDocente { get; set; }
        public String DireccionDocente { get; set; }

        public String EmailDocente { get; set; }
        public String PasswordDocente { get; set; }
        

    }
    //Tabla que se va a utilizar
    [Table("estudiante", Schema = "public")]
    public class registroEstudiante
    {
        [Key]
        public int DocumentoEstudiante { get; set; }
        public String PasswordEstudiante { get; set; }
       

    }
    //Tabla que se va a utilizar
    [Table("administrador", Schema = "public")]
    public class registroAdministrador
    {
        
  
        [Key]
        public String PasswordAdministrador { get; set; }
        public int DocumentoAdministrador { get; set; }

    }
    
}