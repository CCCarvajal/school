using proyecto.DataContext;
using proyecto.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto.Controllers
{
    [Authorize]
    public class DocenteController : Controller
    {
        // GET: Docente
        public ActionResult Index()
        {
            using (ApplicationDbContext2 db = new ApplicationDbContext2())
            {

                return View(db.Cursos.ToList());
            }
        }
        // GET: encabezado sabanas
        public ActionResult SabanasNotas(String NombreMateria)
        {
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {
                return View(db.Notasx.OrderBy(x => x.Materia).ToList());
            }
        }
        public ActionResult SabansNotas()
        {
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {
                return View(db.Notasx.OrderBy(x => x.Materia).ToList());
            }
        }
        [HttpPost]
        public ActionResult Añadir(Notasx notas)
        {
            ApplicationDbContext5 db = new ApplicationDbContext5();
            db.Notasx.Add(new Notasx
            {
                Curso = notas.Curso,
                Documento = notas.Documento,
                Materia = notas.Materia,
                Nota = notas.Nota,
                Apellidos = notas.Apellidos,
                Nombre = notas.Nombre,
                identificador = notas.identificador
            });
            db.SaveChanges();
            return RedirectToAction("SabanasNotas");

        }
        [HttpPost]
        public ActionResult AñadirNota(Notasx notas)
        {
            using (ApplicationDbContext6 db = new ApplicationDbContext6())
            {
                var usuario = db.SubirNotas.Find(1);
                usuario.Nota = 50;
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                var usuario2 = db.SubirNotas.Find(11);
                usuario2.Nota = 40;
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("SabansNotas");

            }
        }
        public FileResult Descargar()
        {
            var ruta = Server.MapPath("/Files/HORAS EXTRAS Y RECARGOS NOCTURNOS COLOMBIA.pdf");
            return File(ruta, "application/pdf");

        }
        // GET: Sabana uno
        public ActionResult SabanaUno()
        {

            return View();
        }
        // GET: Sabana dos
        public ActionResult SabanaDos()
        {

            return View();
        }


        // GET: Docente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Docente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Docente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Docente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Docente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Docente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Docente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult AñadirArchivo(FileModels archivo)
        {
            if (archivo != null) {
                /*
            String Ruta = Server.MapPath("~/");
            String Archivo = Path.Combine(Ruta + "/Files/" + archivo.Archivo.FileName);
            archivo.Archivo.SaveAs(Archivo);*/
                return RedirectToAction("SabansNotas");
            }
            else
            {
                using (ApplicationDbContext7 db = new ApplicationDbContext7())
                {
                    var usuario = db.SubirArchivo.Find("Física");
                    usuario.Estado = 1;
                    db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("SabansNotas");

                }
               
            }
            
        }
        public ActionResult EliminarTarea()
        {
            
                using (ApplicationDbContext7 db = new ApplicationDbContext7())
                {
                    var usuario = db.SubirArchivo.Find("Física");
                    usuario.Estado = 0;
                    db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("SabansNotas");

                }

            

        }

    }
}
