using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.Infra.Data.Repositories;
using TJMT.Prova.Senior.MVC.ViewModels;

namespace TJMT.Prova.Senior.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivroRepository _livroRepository = new LivroRepository();

        // GET: Livros
        public ActionResult Index()
        {
            var retorno = _livroRepository.GetAll();
            var livros = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVM>>(retorno);
            return View(livros);
        }

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroVM livro)
        {
            if (ModelState.IsValid)
            {
                var clientesDomain = Mapper.Map<LivroVM, Livro>(livro);
                _livroRepository.Add(clientesDomain);

                return RedirectToAction("Index");
                 
            }

            return View(livro);
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Livros/Edit/5
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

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Livros/Delete/5
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
