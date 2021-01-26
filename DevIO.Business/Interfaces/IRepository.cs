using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<TEntyti> : IDisposable where TEntyti : Entity
    {

        Task Adicionar(TEntyti entyti);

        Task<TEntyti> ObterPorId(Guid id);

        Task<List<TEntyti>> ObterTodos();

        Task Atualizar(TEntyti entyti);

        Task Remover(Guid id);

        Task<IEnumerable<TEntyti>> Buscar(Expression<Func<TEntyti, bool>> predicate);

        Task<int> SaveChanges();

    }
}
