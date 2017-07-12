using System;
using poki.Core;
namespace poki
{
  public interface IUnitOfWork: IDisposable
  {
    IRepository<TEntity> Resolve<TEntity>() where TEntity:class;

    void Save();

    void Dispose();


  }
}