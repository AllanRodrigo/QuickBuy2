using QuickBuy.Dominio.Contratos;
using System.Collections.Generic;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {
        public BaseRepositorio() { }        
        public void Adicionar(Tentity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Tentity entity)
        {
            throw new System.NotImplementedException();
        }

        public Tentity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Tentity> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(Tentity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
