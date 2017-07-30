using System;
using poki.Core;
namespace poki
{
  public interface IUnitOfWork: IDisposable
  {
    IPersonRepository Persons { get; }
    IGroupsRepository Groups { get; }

    void Save();

    new void Dispose();


  }
}