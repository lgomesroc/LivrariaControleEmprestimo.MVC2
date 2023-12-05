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
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        
        protected ControleEmprestimoLivroContext _Contexto;
        public bool _Savechanges = true;

        public RepositoryBase(bool Savechanges = true)
        {
            _Savechanges = Savechanges;
            _Contexto = new ControleEmprestimoLivroContext();

        }
        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if(_Savechanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);

            if(_Savechanges)
            {
                _Contexto.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPK(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);

            if(_Savechanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public void Savechanges()
        {
            _Contexto.SaveChanges();
        }

        public T? SelecionarPK(params object[] variavel)
        {
            if (_Contexto != null)
            {
                return _Contexto.Set<T>().Find(variavel);
            }
            else
            {
                return default;
            }
        }

        public List<T> SelecionarTodos()
        {
            if (_Contexto != null)
            {
                return _Contexto.Set<T>().ToList();
            }
            else
            {
                return new List<T>();
            }
        }

    }
}
