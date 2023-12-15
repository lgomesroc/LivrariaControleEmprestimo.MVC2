using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Repositories;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class LivroController : Controller
    {
        private readonly LivroController _livroService;
        private object oLivroService;
        private object oRepositoryLivro;

        public LivroController()
        {
            _livroService = new LivroController();
        }
        public IActionResult Index()
        {
            //List<Livro> listaLivros = _livroService.oRepositoryLivro.SelecionarTodos();
            //return View(listaLivros);
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //RepositoryLivro.oRepositoryLivro.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            //Livro oLivro = RepositoryLivro.oRepositoryLivro.SelecionarPK(id);
            //return View(oLivro);
            return View();
        }

        public IActionResult Edit(int id)
        {
            //Livro oLivro = RepositoryLivro.oRepositoryLivro.SelecionarPK(id);
            //return View(oLivro);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Livro model)
        {
            //Livro oLivro = RepositoryLivro.oRepositoryLivro.Alterar(model);
            //int id = oLivro.Id; 
            //return RedirectToAction("Details", new { id });
            return View();
        }

        public IActionResult Delete(int id)
        {
            //RepositoryLivro.oRepositoryLivro.Excluir(id);
            return RedirectToAction("Index");
            //return View();
        }
    }
}
