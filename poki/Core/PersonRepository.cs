using System.Data.Entity;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class PersonRepository:Repository<Persons>, IPersonRepository
  {
    public PersonRepository(PokiContext context) : base(context)
    {
    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }
    public Persons GetPersonResults(int ID)
    {
      return PokiContext.Persons.Include(a => a.results).SingleOrDefault(a => a.ID == ID);
    }
  }
}