using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Repositories;
using LivrariaControleEmprestimo.DATA.Services;
using LivrariaControleEmprestimo.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private readonly ClienteService _clienteService;
        private readonly EmprestimoService _emprestimoService;
        private object oClienteService;
        private object oEmprestimoService;

        public EmprestimosController()
        {
            _clienteService = new ClienteService();
        }

        public IActionResult Index()
        {
            //List<Emprestimo> listaEmporestimo = _emprestimoService.oRepositoryEmprestimo.SelecionarTodos();
            //return View(listaEmporestimo);
            return View();
        }
    }
}