using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    //Tabla que se va a utilizar
    [Table("estudiante", Schema = "public")]
    public class AdministradorModels
    {
        
        public String ApellidoUnoEstudiante{ get; set; } 
        public String ApellidoDosEstudiante { get; set; }
        public String NombreUnoEstudiante { get; set; }
        public String NombreDosEstudiante { get; set; }
        public String GeneroEstudiante { get; set; }
        public String TipoDocumentoEstudiante { get; set; }


        [Key]
        public int DocumentoEstudiante { get; set; }
        public DateTime FechaNacimientoEstudiante { get; set; }
        public String RHEstudiante { get; set; }
        public String EPSEstudiante { get; set; }
        public String TipoEstudiante { get; set; }
        public String DireccionEstudiante { get; set; }
        public long CelularEstudiante { get; set; }
        public String IDEstudianteCurso { get; set; }
        public String EstadoEstudiante { get; set; }
        public String EstadoAcademicoEstudiante { get; set; }
        public String PasswordEstudiante { get; set; }
        public String ApellidoUnoPadre{ get; set; }
        public String ApellidoDosPadre { get; set; }
        public String NombreUnoPadre { get; set; }
        public String NombreDosPadre { get; set; }
        public String TipoDocumentoPadre { get; set; }
        public int DocumentoPadre { get; set; }
        public String DireccionPadre { get; set; }
        public long CelularPadre { get; set; }
        public String ApellidoUnoMadre { get; set; }
        public String ApellidoDosMadre { get; set; }
        public String NombreUnoMadre { get; set; }
        public String NombreDosMadre { get; set; }
        public String TipoDocumentoMadre { get; set; }
        public int DocumentoMadre { get; set; }
        public String DireccionMadre { get; set; }
        public long CelularMadre { get; set; }
        //public int notas { get; set; }
                                           // public virtual RegistroAcudiente DocumentoAcudiente { get; set; }
    }
    //Tabla que se va a utilizar
    [Table("acudiente", Schema = "public")]
    public class RegistroAcudiente
    {
        public String ApellidoUnoAcudiente { get; set; }
        public String ApellidoDosAcudiente { get; set; }
        public String NombreUnoAcudiente { get; set; }
        public String NombreDosAcudiente { get; set; }
        public char GeneroAcudiente { get; set; }
        public int TipoDocumentAcudiente { get; set; }
        [Key]
        public int DocumentoAcudiente { get; set; }
        public int CelularAcudiente { get; set; }
        public int DireccionAcudiente { get; set; }
        public int PasswordAcudiente { get; set; }
        
    }
    //Tabla que se va a utilizar
    [Table("docente", Schema = "public")]
    public class RegistroDocente
    {

        public String ApellidoUnoDocente { get; set; }
        public String ApellidoDosDocente { get; set; }
        public String NombreUnoDocente { get; set; }
        public String NombreDosDocente { get; set; }
        public String GeneroDocente { get; set; }
        public String TipoDocumentoDocente { get; set; }
        [Key]
        public int DocumentoDocente { get; set; }
        public String DireccionDocente { get; set; }
        public String CelularDocente { get; set; }
        public String EmailDocente { get; set; }
        public String PasswordDocente { get; set; }

    }
    //Tabla que se va a utilizar
    [Table("administrador", Schema = "public")]
    public class RegistroAdministrador
    {
        [Key]

        public String ApellidoUnoAdministrador{ get; set; }
        public String ApellidoDosAdministrador { get; set; }
        public String NombreUnoAdministrador { get; set; }
        public String NombreDosAdministrador { get; set; }
        public String GeneroAdministrador { get; set; }
        public String TipoDocumentoAdministrador { get; set; }

        public int DocumentoAdministrador { get; set; }
        public String DireccionAdministrador { get; set; }
        public String CelularAdministrador { get; set; }
        public String EmailAdministrador { get; set; }
        public String PasswordAdministrador { get; set; }

    }//Tabla que se va a utilizar
    [Table("curso", Schema = "public")]
    public class CursosM
    {

        [Key]
        public int IDCurso { get; set; }
        public String NombreCurso { get; set; }



    }
    //Tabla que se va a utilizar
    [Table("curso", Schema = "public")]
    public class CursosModels
    {
        public int IDCurso { get; set; }
        public String NombreCurso { get; set; }
        [Key]
        public String NombreMateria { get; set; }
        public long  DocumentoDocente { get; set; }
        public int ID { get; set; }



    }
    
    //Tabla que se va a utilizar
    [Table("materia", Schema = "public")]
    public class MateriasCOlegio
    {

        [Key]
        public int IDMateria { get; set; }
        public String NombreMateria { get; set; }
       // public virtual Union union{ get; set; }



    }
    

}