using System;
using poki.Core;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace poki
{
  public interface IUnitOfWork: IDisposable
  {
    IRepository<TEntity> Resolve<TEntity>() where TEntity:class;

    int Complete();
    

  }
}