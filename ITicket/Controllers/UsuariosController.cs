using ITicket.Contexts;
using ITicket.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ITicket.Controllers
{
    public class UsuariosController : Controller
    {
        private EFContext context = new EFContext();
        
        UsuarioViewModel usuarioViewModel { get; set; }

        
        // GET: Usuarios
        public ActionResult Index()
        {
            return View(context.Usuarios.OrderBy(c => c.Nome));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuario)
        {
            //gambi
            usuario.SenhaConfirmacao = "";
            usuario.Senha = "  ";
            if (!ModelState.IsValid || !usuario.confirmarSenhasIguais())
            {
                return View(usuario);
            }else{
                context.Usuarios.Add((Usuario)usuario);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
      
        }

        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuario = (UsuarioViewModel)context.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                context.Entry((Usuario)usuario).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuario = context.Usuarios.Find(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuario = context.Usuarios.Find(id);

            if (usuario == null)
            {
                return HttpNotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {

            Usuario usuario = context.Usuarios.Find(id);
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
            TempData["Message"] = "Usuario" +" "+ usuario.Nome.ToUpper() + " " + "Foi Removido com sucesso!";
            return RedirectToAction("Index");
        }

    }
}