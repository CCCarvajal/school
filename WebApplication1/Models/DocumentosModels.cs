using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    public class DocumentosModels
    {
    }
    //Tabla que se va a utilizar
    [Table("curso", Schema = "public")]
    public class DocumentosDocentes
    {
        [Key]
        public int IDCurso { get; set; }
        public String NombreCurso { get; set; }
        public String NombreMateria { get; set; }
        public long DocumentoDocente { get; set; }



    }
}