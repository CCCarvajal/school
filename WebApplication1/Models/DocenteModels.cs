using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    //Tabla que se va a utilizar
    [Table("unioncursomateriadocente", Schema = "public")]

    public class DocenteModels
    {
        [Key]
        public int DocumentoUnionDocente { get; set; }
            public int IDUnionMateria{ get; set; }
            public int IDUnionCurso{ get; set; }
            
        
    }

    [Table("materia", Schema = "public")]
    public class Materias
    {
        [Key]
        public int IDMateria { get; set; }
        public String NombreMateria { get; set; }
        public String NombreGeneralMateria { get; set; }

    }
}