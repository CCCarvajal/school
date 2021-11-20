using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proyecto.Models
{
    public class AñadirNotasModels
    {
        //Tabla que se va a utilizar
        [Table("vaina", Schema = "public")]
        public class SubirNotas
        {
            public Int32 Documento { get; set; }
            public String Curso { get; set; }
            public Int32 Nota { get; set; }
           
            public String Materia { get; set; }
            public String Apellidos { get; set; }
            public String Nombre { get; set; }
            [Key]
            public int identificador { get; set; }

            // public virtual Union union{ get; set; }



        }
    }
}