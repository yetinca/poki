using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poki.Models;

namespace poki.Core
{
  public interface IPersonRepository: IRepository<Persons>
  {
    Persons GetPersonResults(int ID);
  }
}
