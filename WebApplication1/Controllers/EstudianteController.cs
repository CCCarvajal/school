using proyecto.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto.Controllers
{
    [Authorize]
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            
            using (ApplicationDbContext5 db = new ApplicationDbContext5())
            {

                return View(db.Notasx.ToList());
            }
            
        }
        public FileResult Descargar()
        {
            var ruta = Server.MapPath("/Files/HORAS EXTRAS Y RECARGOS NOCTURNOS COLOMBIA.pdf");
            return File(ruta, "application/pdf");

        }
        // GET: Estudiante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estudiante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiante/Create
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

        // GET: Estudiante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estudiante/Edit/5
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

        // GET: Estudiante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estudiante/Delete/5
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
    }
}
