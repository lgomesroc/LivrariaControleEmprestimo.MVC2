using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    interface IRepositoryLivroClienteEmprestimo : IRepositoryModel<LivroClienteEmprestimo>
    {
        new List<LivroClienteEmprestimo> SelecionarTodos();
        new LivroClienteEmprestimo SelecionarPK(params object[] variavel);
        new LivroClienteEmprestimo Incluir(LivroClienteEmprestimo objeto);
        new LivroClienteEmprestimo Alterar(LivroClienteEmprestimo objeto);
        new void Excluir(LivroClienteEmprestimo objeto);
        new void Excluir(params object[] variavel);
        new void Savechanges();
    }
}
