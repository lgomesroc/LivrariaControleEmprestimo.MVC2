using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    interface IRepositoryCliente : IRepositoryModel<Cliente>
    {
        new List<Cliente> SelecionarTodos();
        new Cliente SelecionarPK(params object[] variavel);
        new Cliente Incluir(Cliente objeto);
        new Cliente Alterar(Cliente objeto);
        new void Excluir(Cliente objeto);
        new void Excluir(params object[] variavel);
        new void Savechanges();
    }

}

