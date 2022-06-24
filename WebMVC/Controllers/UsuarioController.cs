using AppUsuarioDAO;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            var usuarioDAO = new UsuarioDAO();
            var todosUsuarios = usuarioDAO.SelectAllUsers();
            return View(todosUsuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var usuarioDAO = new UsuarioDAO();
            var usuarioEspecifico = usuarioDAO.SelectUserById(id);

            if (usuarioEspecifico == null)
                return HttpNotFound(); 

            return View(usuarioEspecifico);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            if (usuario == null)
                return HttpNotFound();

            try
            {
                if(ModelState.IsValid)
                {
                    var usuarioDAO = new UsuarioDAO();
                    usuarioDAO.Insert(usuario);
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var usuarioDAO = new UsuarioDAO();
            var usuarioEspecifico = usuarioDAO.SelectUserById(id);

            if (usuarioEspecifico == null)
                return HttpNotFound();

            return View(usuarioEspecifico);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuario usuario)
        {
            if (usuario == null)
                return HttpNotFound();

            try
            {
                if (ModelState.IsValid)
                {
                    var usuarioDAO = new UsuarioDAO();
                    usuarioDAO.Update(usuario);
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var usuarioDAO = new UsuarioDAO();
            var usuarioEspecifico = usuarioDAO.SelectUserById(id);

            if (usuarioEspecifico == null)
                return HttpNotFound();

            return View(usuarioEspecifico);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Usuario usuario)
        {
            if (usuario == null)
                return HttpNotFound();
            

            try
            {
                if (ModelState.IsValid)
                {
                    var usuarioDAO = new UsuarioDAO();
                    usuarioDAO.Delete(id);
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch
            {
                return View();
            }
        }
    }
}
