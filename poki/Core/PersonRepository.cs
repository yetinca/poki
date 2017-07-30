using System.Data.Entity;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class PersonRepository:Repository<Participants>, IPersonRepository
  {
    public PersonRepository(PokiContext context) : base(context)
    {
    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }
    public Participants GetPersonResults(int ID)
    {
      return PokiContext.Participants.Include(a => a.Results).SingleOrDefault(a => a.ID == ID);
    }
  }
}