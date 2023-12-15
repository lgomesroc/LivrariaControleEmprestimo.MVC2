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
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public static object oRepositoryCliente;

        public RepositoryCliente(bool Savechanges = true) : base(Savechanges)
        {

        }

        protected new ControleEmprestimoLivroContext _Contexto;
        public new bool _Savechanges = true;

        public void RepositoryBase(bool Savechanges = true)
        {
            _Savechanges = Savechanges;
            _Contexto = new ControleEmprestimoLivroContext();

        }
        public new Cliente Alterar(Cliente objeto)
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

        public new void Excluir(Cliente objeto)
        {
            _Contexto.Set<Cliente>().Remove(objeto);

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

        public new Cliente Incluir(Cliente objeto)
        {
            _Contexto.Set<Cliente>().Add(objeto);

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

        public new Cliente SelecionarPK(params object[] variavel)
        {
            if (_Contexto != null)
            {
                return _Contexto.Set<Cliente>().Find(variavel);
            }

            return default;

        }

        public new List<Cliente> SelecionarTodos()
        {
            if (_Contexto != null)
            {
                return _Contexto.Set<Cliente>().ToList();
            }
            return new List<Cliente>();

        }
    }
}