using LivrariaControleEmprestimo.DATA.Models;
using LivrariaControleEmprestimo.DATA.Repositories;
using LivrariaControleEmprestimo.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;
        private object oClienteService;

        public ClienteController()
        {
            _clienteService = new ClienteService();
        }

        public IActionResult Index()
        {
            List<Cliente> listaClientes = _clienteService.oRepositoryCliente.SelecionarTodos();
            return View(listaClientes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            RepositoryCliente.oRepositoryCliente.Incluir(model);


            return RedirectToAction("Index");
        }
    }
}
