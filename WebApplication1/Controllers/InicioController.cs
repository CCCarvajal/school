using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Npgsql;
using proyecto.DataContext;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class InicioController : Controller
    {
        


        // GET: Inicio
        public ActionResult Index(string mensaje )

        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                
                return View();
            }
        }

        //BUSCAR USUSARIO
        
        [HttpPost]
        public ActionResult Iniciar(int usuario, String contraseña )
        {
            
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var x = contraseña + "\n";
                if (usuario != 0)
                {
                    var lst = from d in db.Empobj
                              where d.DocumentoDocente == usuario & d.PasswordDocente == contraseña
                              select d;
                    if (lst.Count() > 0)
                    {
                        FormsAuthentication.SetAuthCookie(usuario.ToString(), true);

                        return Content("1");
                    }
                    else
                    {
                        var lst1 = from d in db.Estudiante
                                   where d.DocumentoEstudiante == usuario & d.PasswordEstudiante == contraseña
                                   select d;
                        if (lst1.Count() > 0)
                        {
                            FormsAuthentication.SetAuthCookie(usuario.ToString(), true);

                            return Content("2");
                        }
                        else
                        {
                            var lst2 = from d in db.Administrador
                            
                            where d.DocumentoAdministrador == usuario & d.PasswordAdministrador == x
                            select d;
                            if (lst2.Count() > 0)
                            {
                                FormsAuthentication.SetAuthCookie(usuario.ToString(), true);

                                return Content("3");
                            }
                            else
                            {
                                
                                if (lst2.Count() > 0)
                                {
                                    FormsAuthentication.SetAuthCookie(usuario.ToString(), true); 

                                    return Content("3");
                                }
                                else
                                {

                                    return Content("4");
                                }
                                
                            }
                        }
                    }
                }
            
                //re enviar a vista ViewBag

                // var lista = db.Empobj.Where(e => e.DocumentoDocente == usuario).ToString();
                return Content("4");
            
            }
        }
        [Authorize]
        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
      public ActionResult Correo(String email, int documento)
        {
            
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                
                    String Origen = "camilocarvajalyoop@gmail.com";
                    String Destino = email;
                    String Contrasena = "obscure123";
                    String mensaje = "Aquí se podrá recuperar la contraseña de la plataforma mediante un correo electronico destidnado para el usuario: " + documento.ToString() + "\n <a href='http://localhost:51429/Inicio/EditarContraseña'> link a la plataforma</a>";
                    MailMessage correo = new MailMessage(Origen, Destino, "Recuperar contraseña", mensaje);
                    correo.IsBodyHtml = true;
                    //MailAddress correo = new MailAddress(Origen, Destino, "Asunto hola", "el mensaje es este");
                    SmtpClient cliente = new SmtpClient("smtp.gmail.com");
                    cliente.EnableSsl = true;
                    cliente.UseDefaultCredentials = false;
                    cliente.Port = 587;
                    cliente.Credentials = new NetworkCredential(Origen, Contrasena);
                    cliente.Send(correo);
                    cliente.Dispose();
                    return Content("Correo Enviado");
                
            }
            return Content(email + documento);



        }
        public ActionResult EditarContraseña()
        {

            
                return View();




        }



    }
}
