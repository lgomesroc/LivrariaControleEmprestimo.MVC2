using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Interfaces
{
    interface IRepositoryLivro : IRepositoryModel<Livro>
    {
        new List<Livro> SelecionarTodos();
        new Livro SelecionarPK(params object[] variavel);
        new Livro Incluir(Livro objeto);
        new Livro Alterar(Livro objeto);
        new void Excluir(Livro objeto);
        new void Excluir(params object[] variavel);
        new void Savechanges();
    }
}

