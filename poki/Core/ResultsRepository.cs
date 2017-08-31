using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using poki.Models;

namespace poki.Core
{
  public class ResultsRepository:Repository<Results>, IResultsRepository
  {
    public ResultsRepository(PokiContext context): base(context)
    {

    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }
  }
}