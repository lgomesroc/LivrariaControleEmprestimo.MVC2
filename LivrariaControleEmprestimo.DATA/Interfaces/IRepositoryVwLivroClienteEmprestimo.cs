using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    interface IRepositoryVwLivroClienteEmprestimo : IRepositoryModel<VwLivroClienteEmprestimo>
    {
        new List<VwLivroClienteEmprestimo> SelecionarTodos();
        new VwLivroClienteEmprestimo SelecionarPK(params object[] variavel);
        new VwLivroClienteEmprestimo Incluir(VwLivroClienteEmprestimo objeto);
        new VwLivroClienteEmprestimo Alterar(VwLivroClienteEmprestimo objeto);
        new void Excluir(VwLivroClienteEmprestimo objeto);
        new void Excluir(params object[] variavel);
        new void Savechanges();
    }

}

