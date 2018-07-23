using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using TJMT.Prova.Senior.Application.Interface;
using TJMT.Prova.Senior.Domain.Entities;
using TJMT.Prova.Senior.MVC.ViewModels;

namespace TJMT.Prova.Senior.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroAppService _livroAppService;

        public LivrosController(ILivroAppService livroAppService)
        {
            _livroAppService = livroAppService;

        }

        // GET: Livros
        public ActionResult Index()
        {
            var retorno = _livroAppService.GetAll();
            var livros = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVM>>(retorno);
            return View(livros);
        }

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
            var retorno = _livroAppService.GetById(id);
            var livros = Mapper.Map<Livro,LivroVM>(retorno);
            return View(livros);
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
                _livroAppService.Add(clientesDomain);

                return RedirectToAction("Index");
                 
            }

            return View(livro);
        }

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
            var retorno = _livroAppService.GetById(id);
            var livros = Mapper.Map<Livro, LivroVM>(retorno);
            return View(livros);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        public ActionResult Edit(LivroVM livro)
        {
            if (ModelState.IsValid)
            {
                var retorno = Mapper.Map<LivroVM, Livro>(livro);
                _livroAppService.Update(retorno);

                return RedirectToAction("Index");
            }


            return View(livro);
        }

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
            var retorno = _livroAppService.GetById(id);
            var livros = Mapper.Map<Livro, LivroVM>(retorno);
            return View(livros);
        }

        // POST: Livros/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var retorno = _livroAppService.GetById(id);
            _livroAppService.Remove(retorno);

            return RedirectToAction("Index");
        }
    }
}
