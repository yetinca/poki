using poki.Models;

namespace poki.Core
{
  public class ProperResultsQuestionRepository : Repository<ProperResultsQuestion>, IProperResultsQuestionRepository
  {
    public ProperResultsQuestionRepository(PokiContext context) : base(context)
    {
    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }
  }
}