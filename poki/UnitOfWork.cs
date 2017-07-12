using System;
using poki.Core;
using poki.Models;

namespace poki
{
  public class UnitOfWork:IUnitOfWork

  {
    private bool _disposed;
    private readonly PokiContext _context;
    public UnitOfWork(PokiContext context)
    {
      _context = context;

    }
    public IRepository<TEntity> Resolve<TEntity>() where TEntity : class
    {
      return new Repository<TEntity>(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }

    private void Dispose(bool disposing)
    {
      if (_disposed == false)
      {
        if (disposing)
        {
          _context.Dispose();
        }
      }
      _disposed = true;
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}