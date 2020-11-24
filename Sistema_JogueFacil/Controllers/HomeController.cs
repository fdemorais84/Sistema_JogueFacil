using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sistema_JogueFacil.Models;

namespace Sistema_JogueFacil.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario u)
        {
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {
                using (CadastroEntities dc = new CadastroEntities())
                {
                    var v = dc.Usuarios.Where(a => a.NOME_USUARIO.Equals(u.NOME_USUARIO) && a.SENHA.Equals(u.SENHA)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["usuarioLogadoID"] = v.ID.ToString();
                        Session["nomeUsuarioLogado"] = v.NOME_USUARIO.ToString();
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(u);
        }
    }
}