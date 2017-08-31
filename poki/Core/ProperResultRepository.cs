using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class ProperResultRepository : Repository<ProperResult>, IProperResultRepository
  {
    public ProperResultRepository(PokiContext context) : base(context)
    {
    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }

 
  }
}