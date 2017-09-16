using ITicket.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITicket.Controllers
{
    public class UsuariosController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Usuarios
        public ActionResult Index()
        {
            return View(context.Usuarios.OrderBy(c => c.Nome));

        }
    }
}