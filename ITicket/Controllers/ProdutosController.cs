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
public class ProdutosController : Controller
{
    private EFContext context = new EFContext();

    public ActionResult Index()
    {
        var produtos = context.Produtos.Include(e => e.Empresa).OrderBy(n => n.Nome);
        return View(produtos);
    }

    public ActionResult Create()
    {
        ViewBag.EmpresaId = new SelectList(context.Empresas.OrderBy(b => b.Nome), "EmpresaId", "Nome");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Produto produto)
    {
        try{
                          

        context.Produtos.Add(produto);
        context.SaveChanges();
        return RedirectToAction("Index");

        }catch{
            return View(produto);
        }
    }



        public ActionResult Edit(long? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        Produto produto = context.Produtos.Find(id);
        if (produto == null)
        {
            return HttpNotFound();
        }

        ViewBag.EmpresaId = new SelectList(context.Empresas.OrderBy(b => b.Nome), "EmpresaId", "Nome");
        return View(produto);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(Produto produto)
    {
        try{
            if (ModelState.IsValid){
                context.Entry(produto).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        return View(produto);

        }catch{
            return View(produto);
        }
    }
    

    public ActionResult Details(long? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Produto produto = context.Produtos.Find(id);

        if (produto == null)
        {
            return HttpNotFound();
        }
        return View(produto);
    }

    public ActionResult Delete(long? id)
    {
        if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        Produto produto = context.Produtos.Find(id);

        if (produto == null)
        {
            return HttpNotFound();
        }

        return View(produto);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(long id)
    {

        Produto produto = context.Produtos.Find(id);
        context.Produtos.Remove(produto);
        context.SaveChanges();
        return RedirectToAction("Index");
    }

}
}