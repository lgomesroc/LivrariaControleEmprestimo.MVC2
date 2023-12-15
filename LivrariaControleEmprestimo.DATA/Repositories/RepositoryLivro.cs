using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public static object oRepositoryLivro;

        public RepositoryLivro(bool Savechanges = true) : base(Savechanges)
        {

        }

        protected new ControleEmprestimoLivroContext _Contexto;
        public new bool _Savechanges = true;

        public void RepositoryBase(bool Savechanges = true)
        {
            _Savechanges = Savechanges;
            _Contexto = new ControleEmprestimoLivroContext();

        }
        public new Livro Alterar(Livro objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if (_Savechanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public new void Dispose()
        {
            _Contexto.Dispose();
        }

        public new void Excluir(Livro objeto)
        {
            _Contexto.Set<Livro>().Remove(objeto);

            if (_Savechanges)
            {
                _Contexto.SaveChanges();
            }
        }

        public new void Excluir(params object[] variavel)
        {
            var obj = SelecionarPK(variavel);
            Excluir(obj);
        }

        public new Livro Incluir(Livro objeto)
        {
            _Contexto.Set<Livro>().Add(objeto);

            if (_Savechanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public new void Savechanges()
        {
            _Contexto.SaveChanges();
        }

        public new Livro SelecionarPK(params object[] variavel)
        {
            if (_Contexto != null)
            {
                return _Contexto.Set<Livro>().Find(variavel);
            }

            return default;

        }

        public new List<Livro> SelecionarTodos()
        {
            if (_Contexto != null)
            {
                return _Contexto.Set<Livro>().ToList();
            }
            return new List<Livro>();

        }
    }
} 