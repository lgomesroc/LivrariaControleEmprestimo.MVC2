using LivrariaControleEmprestimo.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class EmprestimoService
    {
        public RepositoryLivro oRepositoryEmprestimo { get; set; }

        public void LivroService()
        {
            oRepositoryEmprestimo = new RepositoryLivro();
        }
    }
}
