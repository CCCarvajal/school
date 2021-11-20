using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    //Tabla que se va a utilizar
    [Table("vaina", Schema = "public")]
    public class FileModels
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

    }
}