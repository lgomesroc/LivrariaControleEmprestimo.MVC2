using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryVwLivroClienteEmprestimo : RepositoryBase<VwLivroClienteEmprestimo>, IRepositoryVwLivroClienteEmprestimo
    {
        public static object oRepositoryVwLivroClienteEmprestimo;

        public RepositoryVwLivroClienteEmprestimo(bool Savechanges = true) : base(Savechanges) 
        {

        }
    }
}
