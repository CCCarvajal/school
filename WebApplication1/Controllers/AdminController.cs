using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proyecto.DataContext;
using proyecto.Models;
using static proyecto.Models.CursosModels2;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.Data;

namespace Plataforma.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ApplicationDbContext2 db = new ApplicationDbContext2();
       
        //MOSTRAR PLANTILLA DE INICIO ADMINISTRADOR
        public ActionResult Index()
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                return View(db.Cursos.OrderBy(x => x.IDCurso).ToList());
            }

        }
       
        //MOSTRAR PLANTILLA DE CREAR ESTUDIANTE
        public ActionResult CrearEstudiante()
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
            return View(db.RegistroEstudiante.ToList());
            }
        }

        //AGREGAR UN ESTUDIANTE
        [HttpPost]
        public ActionResult CrearRegistroEstudiante(
            String registro_apellido_uno_estudiante, String registro_apellido_dos_estudiante,
            String registro_nombre_uno_estudiante, String registro_nombre_dos_estudiante,
            String registro_genero_estudiante, String registro_tipoDocumento_estudiante,
            int registro_documento_estudiante, DateTime registro_fechaNacimiento_estudiante,
            String registro_rh_estudiante, String registro_eps_estudiante,
            String registro_tipoEstudiante, String registro_direccion_estudiante,
            long registro_celular_estudiante, String registro_curso_estudiante,
            String registro_estado_estudiante, String registro_apellido_uno_padre, String registro_apellido_dos_padre,
            String registro_nombre_uno_padre, String registro_nombre_dos_padre,
            String registro_tipoDocumento_padre, int registro_documento_padre, String registro_direccion_padre,
            long registro_celular_padre, String registro_apellido_uno_madre,
            String registro_apellido_dos_madre, String registro_nombre_uno_madre,
            String registro_nombre_dos_madre, String registro_tipoDocumento_madre,
            int registro_documento_madre, String registro_direccion_madre,
            long registro_celular_madre
            )
        {
            Random pass = new Random();
            //CREAMOS UNA LISTA DE LOS DATOS DEL ESTUDIANTE

            using (ApplicationDbContext2 db = new ApplicationDbContext2())

            {
                ApplicationDbContext5 db2 = new ApplicationDbContext5();
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Matemáticas",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.SaveChanges();

                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Español",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Ingles",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Ciencias Naturales",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Biología",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Química",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Física",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Artes",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Música",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });
                db2.Notasx.Add(new Notasx
                {
                    Documento = registro_documento_estudiante,
                    Curso = registro_curso_estudiante,
                    Nota = 0,
                    Materia = "Cálculo",
                    Apellidos = registro_apellido_uno_estudiante + " " + registro_apellido_dos_estudiante,
                    Nombre = registro_nombre_uno_estudiante + " " + registro_nombre_dos_estudiante

                });

                db2.SaveChanges();

                db.RegistroEstudiante.Add(new AdministradorModels
                {
                    DocumentoEstudiante = registro_documento_estudiante,
                    ApellidoUnoEstudiante = registro_apellido_uno_estudiante,
                    ApellidoDosEstudiante = registro_apellido_dos_estudiante,
                    NombreUnoEstudiante = registro_nombre_uno_estudiante,
                    NombreDosEstudiante = registro_nombre_dos_estudiante,
                    GeneroEstudiante = registro_genero_estudiante,
                    TipoDocumentoEstudiante = registro_tipoDocumento_estudiante,
                    FechaNacimientoEstudiante = registro_fechaNacimiento_estudiante,
                    RHEstudiante = registro_rh_estudiante,
                    EPSEstudiante = registro_eps_estudiante,
                    TipoEstudiante = registro_tipoEstudiante,
                    DireccionEstudiante = registro_direccion_estudiante,
                    CelularEstudiante = registro_celular_estudiante,
                    IDEstudianteCurso = "602",
                    EstadoEstudiante = registro_estado_estudiante,
                    EstadoAcademicoEstudiante = "x",
                    PasswordEstudiante = pass.Next(10000, 99999).ToString(),
                    ApellidoUnoPadre = registro_apellido_uno_padre,
                    ApellidoDosPadre = registro_apellido_dos_padre,
                    NombreUnoPadre = registro_nombre_uno_padre,
                    NombreDosPadre = registro_nombre_dos_padre,
                    TipoDocumentoPadre = registro_tipoDocumento_padre,
                    DocumentoPadre = registro_documento_padre,
                    DireccionPadre = registro_direccion_padre,
                    CelularPadre = registro_celular_padre,
                    ApellidoUnoMadre = registro_apellido_uno_madre,
                    ApellidoDosMadre = registro_apellido_dos_madre,
                    NombreUnoMadre = registro_nombre_uno_madre,
                    NombreDosMadre = registro_nombre_dos_madre,
                    TipoDocumentoMadre = registro_tipoDocumento_madre,
                    DocumentoMadre = registro_documento_madre,
                    DireccionMadre = registro_direccion_madre,
                    CelularMadre = registro_celular_madre
                });
                db.SaveChanges();

                return RedirectToAction("CrearEstudiante");

            }
        }
        //EDITAR ESTUDIANTE
       public ActionResult EditarEstudiante(int Id)
        {
            AdministradorModels modelo = new AdministradorModels();
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                var usuario = db.RegistroEstudiante.Find(Id);
                modelo.ApellidoUnoEstudiante = usuario.ApellidoUnoEstudiante;
                modelo.ApellidoDosEstudiante = usuario.ApellidoDosEstudiante;
                modelo.NombreUnoEstudiante = usuario.NombreUnoEstudiante;
                modelo.NombreDosEstudiante = usuario.NombreDosEstudiante;
                modelo.GeneroEstudiante = usuario.GeneroEstudiante;
                modelo.TipoDocumentoEstudiante = usuario.TipoDocumentoEstudiante;
                modelo.DocumentoEstudiante = usuario.DocumentoEstudiante;
                modelo.FechaNacimientoEstudiante = usuario.FechaNacimientoEstudiante;
                modelo.DocumentoEstudiante = usuario.DocumentoEstudiante;
                modelo.FechaNacimientoEstudiante = usuario.FechaNacimientoEstudiante;
                modelo.RHEstudiante = usuario.RHEstudiante;
                modelo.EPSEstudiante = usuario.EPSEstudiante;
                modelo.TipoEstudiante = usuario.TipoEstudiante;
                modelo.DireccionEstudiante = usuario.DireccionEstudiante;
                modelo.CelularEstudiante = usuario.CelularEstudiante;
                modelo.IDEstudianteCurso = usuario.IDEstudianteCurso;
                modelo.EstadoEstudiante = usuario.EstadoEstudiante;
                modelo.EstadoAcademicoEstudiante = usuario.EstadoAcademicoEstudiante;
                modelo.PasswordEstudiante = usuario.PasswordEstudiante;
                modelo.ApellidoUnoPadre = usuario.ApellidoUnoPadre;
                modelo.ApellidoDosPadre = usuario.ApellidoDosPadre;
                modelo.NombreUnoPadre = usuario.NombreUnoPadre;
                modelo.NombreDosPadre = usuario.NombreDosPadre;
                modelo.TipoDocumentoPadre = usuario.TipoDocumentoPadre;
                modelo.DocumentoPadre = usuario.DocumentoPadre;
                modelo.DireccionPadre = usuario.DireccionPadre;
                modelo. CelularPadre = usuario.CelularPadre;
                modelo.ApellidoUnoMadre = usuario.ApellidoUnoMadre;
                modelo.ApellidoDosMadre = usuario.ApellidoDosMadre;
                modelo.NombreUnoMadre = usuario.NombreUnoMadre;
                modelo.NombreDosMadre = usuario.NombreDosMadre;
                modelo.TipoDocumentoMadre = usuario.TipoDocumentoMadre;
                modelo.DocumentoMadre = usuario.DocumentoMadre;
                modelo.DireccionMadre = usuario.DireccionMadre;
                modelo.CelularMadre = usuario.CelularMadre;
                return View(modelo);
            }


        }
        [HttpPost]
        public ActionResult EditarRegistroEstudiante(int id,
            String registro_apellido_uno_estudiante, String registro_apellido_dos_estudiante,
            String registro_nombre_uno_estudiante, String registro_nombre_dos_estudiante,
            String registro_genero_estudiante, String registro_tipoDocumento_estudiante,
            int registro_documento_estudiante, DateTime registro_fechaNacimiento_estudiante,
            String registro_rh_estudiante, String registro_eps_estudiante,
            String registro_tipoEstudiante, String registro_direccion_estudiante,
            long registro_celular_estudiante, String registro_curso_estudiante,
            String registro_estado_estudiante, String registro_password_estudiante, String registro_apellido_uno_padre, String registro_apellido_dos_padre,
            String registro_nombre_uno_padre, String registro_nombre_dos_padre,
            String registro_tipoDocumento_padre, int registro_documento_padre, String registro_direccion_padre,
            long registro_celular_padre, String registro_apellido_uno_madre,
            String registro_apellido_dos_madre, String registro_nombre_uno_madre,
            String registro_nombre_dos_madre, String registro_tipoDocumento_madre,
            int registro_documento_madre, String registro_direccion_madre,
            long registro_celular_madre)
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                var usuario = db.RegistroEstudiante.Find(id);
                usuario.ApellidoUnoEstudiante = registro_apellido_uno_estudiante;
                usuario.ApellidoDosEstudiante = registro_apellido_dos_estudiante;
                usuario.NombreUnoEstudiante = registro_nombre_uno_estudiante;
                usuario.NombreDosEstudiante = registro_nombre_dos_estudiante;
                usuario.GeneroEstudiante = registro_genero_estudiante;
                usuario.TipoDocumentoEstudiante = registro_tipoDocumento_estudiante;
                usuario.DocumentoEstudiante = registro_documento_estudiante;
                usuario.FechaNacimientoEstudiante = registro_fechaNacimiento_estudiante;
                usuario.RHEstudiante = registro_rh_estudiante;
                usuario.EPSEstudiante = registro_eps_estudiante;
                usuario.TipoEstudiante = registro_tipoEstudiante;
                usuario.DireccionEstudiante = registro_direccion_estudiante;
                usuario.CelularEstudiante = registro_celular_estudiante;
                usuario.IDEstudianteCurso = registro_curso_estudiante;
                usuario.EstadoEstudiante = registro_estado_estudiante;
                usuario.EstadoAcademicoEstudiante = registro_estado_estudiante;
                usuario.PasswordEstudiante = registro_password_estudiante;
                usuario.ApellidoUnoPadre = registro_apellido_uno_padre;
                usuario.ApellidoDosPadre = registro_apellido_dos_padre;
                usuario.NombreUnoPadre = registro_nombre_uno_padre;
                usuario.NombreDosPadre = registro_nombre_dos_padre;
                usuario.TipoDocumentoPadre = registro_tipoDocumento_padre;
                usuario.DocumentoPadre = registro_documento_padre;
                usuario.DireccionPadre = registro_direccion_padre;
                usuario.CelularPadre = registro_celular_padre;
                usuario.ApellidoUnoMadre = registro_apellido_uno_madre;
                usuario.ApellidoDosMadre = registro_apellido_dos_madre;
                usuario.NombreUnoMadre = registro_nombre_uno_madre;
                usuario.NombreDosMadre = registro_nombre_dos_madre;
                usuario.TipoDocumentoMadre = registro_tipoDocumento_madre;
                usuario.DocumentoMadre = registro_documento_madre;
                usuario.DireccionMadre = registro_direccion_madre;
                usuario.CelularMadre = registro_celular_madre;
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CrearEstudiante");
            }
        }


            //MOSTRAR PLANTILLA DE CREAR DOCENTE
            public ActionResult CrearDocente()
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                return View(db.RegistroDocente.ToList());
            }
        }
        //CREAR REGISTRO DEL DOCENTE
        [HttpPost]
        public ActionResult CrearRegistroDocente(
            String registro_apellido_uno_docente,
            String registro_apellido_dos_docente,
            String registro_nombre_uno_docente,
            String registro_nombre_dos_docente,
            String registro_genero_docente,
            String registro_tipoDocumento_docente,
            int registro_documento_docente,
            String registro_direccion_docente,
            String registro_celular_docente,
            String registro_email_docente

            )
        {
            Random pass = new Random();
            //CREAMOS UNA NUEVO DOCENTE
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                db.RegistroDocente.Add(new RegistroDocente
                {
                    ApellidoUnoDocente = registro_apellido_uno_docente,
                    ApellidoDosDocente = registro_apellido_dos_docente,
                    NombreUnoDocente = registro_nombre_uno_docente,
                    NombreDosDocente = registro_nombre_dos_docente,
                    GeneroDocente = registro_genero_docente,
                    TipoDocumentoDocente = registro_tipoDocumento_docente,
                    DocumentoDocente = registro_documento_docente,
                    DireccionDocente = registro_direccion_docente,
                    CelularDocente = registro_celular_docente,
                    EmailDocente = registro_email_docente,
                    PasswordDocente = pass.Next(10000, 99999).ToString()
                });
                db.SaveChanges();
                return RedirectToAction("CrearDocente");

            }

        }
        //EDITAR DOCENTE
        public ActionResult EditarDocente(int Id)
        {
            RegistroDocente modelo = new RegistroDocente();
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                var usuario = db.RegistroDocente.Find(Id);
                modelo.ApellidoUnoDocente = usuario.ApellidoUnoDocente;
                modelo.ApellidoDosDocente = usuario.ApellidoDosDocente;
                modelo.NombreUnoDocente = usuario.NombreUnoDocente;
                modelo.NombreDosDocente = usuario.NombreDosDocente;
                modelo.GeneroDocente = usuario.GeneroDocente;
                modelo.TipoDocumentoDocente = usuario.TipoDocumentoDocente;
                modelo.DocumentoDocente = usuario.DocumentoDocente;
                modelo.DireccionDocente = usuario.DireccionDocente;
                modelo.CelularDocente = usuario.CelularDocente;
                modelo.EmailDocente = usuario.EmailDocente;
                modelo.PasswordDocente = usuario.PasswordDocente;
                
                return View(modelo);
            }


        }
        [HttpPost]
        public ActionResult EditarRegistroDocente( RegistroDocente profesor)
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                var usuario = db.RegistroDocente.Find(profesor.DocumentoDocente);
                usuario.ApellidoUnoDocente = profesor.ApellidoUnoDocente;
                usuario.ApellidoDosDocente = profesor.ApellidoDosDocente;
                usuario.NombreUnoDocente = profesor.NombreUnoDocente;
                usuario.NombreDosDocente = profesor.NombreDosDocente;
                usuario.GeneroDocente = profesor.GeneroDocente;
                usuario.TipoDocumentoDocente = profesor.TipoDocumentoDocente;
                usuario.DocumentoDocente = profesor.DocumentoDocente;
                usuario.DireccionDocente = profesor.DireccionDocente;
                usuario.CelularDocente = profesor.CelularDocente;
                usuario.EmailDocente = profesor.EmailDocente;
                usuario.PasswordDocente = profesor.PasswordDocente;
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CrearDocente");
            }
        }


        //MOSTRAR PLANTILLA DE CREAR ADMINISTRADOR
        public ActionResult CrearAdministrador()
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                return View(db.RegistroAdministrador.ToList());
            }
        }
        //EDITAR ADMINISTRADOR
        public ActionResult EditarAdministrador(int Id)
        {
            RegistroAdministrador modelo = new RegistroAdministrador();
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                var usuario = db.RegistroAdministrador.Find(Id);
                modelo.ApellidoUnoAdministrador = usuario.ApellidoUnoAdministrador;
                modelo.ApellidoDosAdministrador = usuario.ApellidoDosAdministrador;
                modelo.NombreUnoAdministrador = usuario.NombreUnoAdministrador;
                modelo.NombreDosAdministrador = usuario.NombreDosAdministrador;
                modelo.GeneroAdministrador = usuario.GeneroAdministrador;
                modelo.TipoDocumentoAdministrador = usuario.TipoDocumentoAdministrador;
                modelo.DocumentoAdministrador = usuario.DocumentoAdministrador;
                modelo.DireccionAdministrador = usuario.DireccionAdministrador;
                modelo.CelularAdministrador = usuario.CelularAdministrador;
                modelo.EmailAdministrador = usuario.EmailAdministrador;
                modelo.PasswordAdministrador = usuario.PasswordAdministrador;

                return View(modelo);
            }


        }
        [HttpPost]
        public ActionResult EditarRegistroAdministrador(RegistroAdministrador  admin)
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                var usuario = db.RegistroAdministrador.Find(admin.DocumentoAdministrador);
                usuario.ApellidoUnoAdministrador = admin.ApellidoUnoAdministrador;
                usuario.ApellidoDosAdministrador = admin.ApellidoDosAdministrador;
                usuario.NombreUnoAdministrador = admin.NombreUnoAdministrador;
                usuario.NombreDosAdministrador = admin.NombreDosAdministrador;
                usuario.GeneroAdministrador = admin.GeneroAdministrador;
                usuario.TipoDocumentoAdministrador = admin.TipoDocumentoAdministrador;
                usuario.DocumentoAdministrador = admin.DocumentoAdministrador;
                usuario.DireccionAdministrador = admin.DireccionAdministrador;
                usuario.CelularAdministrador = admin.CelularAdministrador;
                usuario.EmailAdministrador = admin.EmailAdministrador;
                usuario.PasswordAdministrador = admin.PasswordAdministrador;
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CrearAdministrador");
            }
        }
        //CREAR REGISTRO DEL DOCENTE
        [HttpPost]
        public ActionResult CrearRegistroAdministrador(
            String registro_apellido_uno_administrador,
            String registro_apellido_dos_administrador,
            String registro_nombre_uno_administrador,
            String registro_nombre_dos_administrador,
            String registro_genero_administrador,
            String registro_tipoDocumento_administrador,
            int registro_documento_administrador,
            String registro_direccion_administrador,
            String registro_celular_administrador,
            String registro_email_administrador
            )
        {
            Random pass = new Random();
            //CREAMOS UNA NUEVO ADMINISTRADOR
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                db.RegistroAdministrador.Add(new RegistroAdministrador
                {
                    ApellidoUnoAdministrador = registro_apellido_uno_administrador,
                    ApellidoDosAdministrador = registro_apellido_dos_administrador,
                    NombreUnoAdministrador = registro_nombre_uno_administrador,
                    NombreDosAdministrador = registro_nombre_dos_administrador,
                    GeneroAdministrador = registro_genero_administrador,
                    TipoDocumentoAdministrador = registro_tipoDocumento_administrador,
                    DocumentoAdministrador = registro_documento_administrador,
                    DireccionAdministrador = registro_direccion_administrador,
                    CelularAdministrador = registro_celular_administrador,
                    EmailAdministrador = registro_email_administrador,
                    PasswordAdministrador = pass.Next(10000, 99999).ToString()
                });
                db.SaveChanges();
                return RedirectToAction("CrearAdministrador");

            }

        }
      
        //MOSTRAR PLANTILLA DE CREAR ADMINISTRADOR
        public ActionResult CrearDocenteInicio()
        {
            return View();
        }
        //MOSTRAR PLANTILLA DE CREAR ADMINISTRADOR
        public ActionResult AsignarMaterias()
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                // var x = db.Tablas;
                ApplicationDbContext2 db2 = new ApplicationDbContext2();

                return View(db.Cursos.OrderBy(x => x.IDCurso).ToList());
            }
                
        }
        //Asignar materias
        [HttpPost]
        public ActionResult Asignar(
            CursosModels curso
            )
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {
                if (ModelState.IsValid)
                {
                    db.Cursos.Add(curso);
                    db.SaveChanges();
                    return RedirectToAction("AsignarMaterias");
                }
            }
            return RedirectToAction("AsignarMaterias");

        }


        //eliminar
        public ActionResult Eliminar(int ID)
        {
            using (ApplicationDbContext4 db = new ApplicationDbContext4())
            {
                DocumentosDocentes EiminarRegistro = db.Documento.Find(ID);
                db.Documento.Remove(EiminarRegistro);
                db.SaveChanges();
                return RedirectToAction("AsignarMaterias");
            }
        }
        /*
        [HttpPost]
        //notas
        public ActionResult AN(String IDEstudianteCurso, int notas)
        {
            using (ApplicationDbContext4 db = new ApplicationDbContext4())
            {
                DocumentosDocentes EiminarRegistro = db.Documento.Find(IDEstudianteCurso);
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AsignarMaterias");
            }
        }
        */
        //MOSTRAR PLANTILLA DE CREAR ADMINISTRADOR
        public ActionResult SabanasNotas(String id)
        {
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {
                String x = id;
                List<Cursos2> Docentes2 = new List<Cursos2>();
                var lst = from d in db.Cursos2
                          where d.NombreCurso == id 
                          select d;



                return View(lst.OrderBy(y => y.DocumentoDocente).ToList());
            }
        }
        public ActionResult NotasEstudiantes()
        {
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {

                List<Cursos2> Docentes2 = new List<Cursos2>();
                var lst = from d in db.Cursos2
                          where d.NombreCurso == "601-M"
                          select d;



                return View(lst.OrderBy(y => y.DocumentoDocente).ToList());
            }
        }
        public ActionResult SabanaUno(String curso)
        {
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {
                 
                return View(db.Notasx.ToList());
            }
        }
        [HttpPost]
        public ActionResult AñadirNota(Notasx notas)
        {
            ApplicationDbContext5 db = new ApplicationDbContext5();
                db.Notasx.Add(new Notasx
                {
                    Curso = notas.Curso,
                    Documento = notas.Documento,
                    Materia = notas.Materia,
                    Nota = notas.Nota,
                    Apellidos = notas.Apellidos,
                    Nombre = notas.Nombre
                });
                db.SaveChanges();
                return RedirectToAction("SabanaUno");
            
        }
        public ActionResult SabanaDos(String curso)
        {
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {

                return View(db.Notasx.ToList());
            }
        }

    }
}
