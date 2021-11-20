using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    public class CursosModels2
    {
    }
        //Tabla que se va a utilizar
        [Table("curso", Schema = "public")]
        public class Cursos2
        {
            public int IDCurso { get; set; }
            [Key]
            public String NombreCurso { get; set; }
            public String NombreMateria { get; set; }
            public long DocumentoDocente { get; set; }
            public int ID { get; set; }


        }
    //Tabla que se va a utilizar
    [Table("vaina", Schema = "public")]
    public class Notasx
    {
        public Int32 Documento { get; set; }
        public String Curso { get; set; }
        public Int32 Nota { get; set; }
        [Key]
        public String Materia { get; set; }
        public String Apellidos { get; set; }
        public String Nombre { get; set; }
        public int identificador { get; set; }
        public int Estado { get; set; }

        // public virtual Union union{ get; set; }



    }

}