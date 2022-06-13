using AppUsuarioDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var usuarioDAO = new UsuarioDAO();
            var todosUsuarios = usuarioDAO.Select();
            return View(todosUsuarios);
        }
    
    }
}