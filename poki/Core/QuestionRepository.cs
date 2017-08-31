using System.Collections.Generic;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class QuestionRepository:Repository<Question>, IQuestionRepository
  {
    public QuestionRepository(PokiContext context) : base(context)
    {
    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }

    public IEnumerable<Question> OrderedQuestions()
    {
      var ordered = PokiContext.Questions.OrderBy(a => a.OrderNumber);

      return ordered;
    }
  }
}