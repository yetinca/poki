using System.Data.Entity;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class GroupsRepository:Repository<groups>, IGroupsRepository
  {
    public GroupsRepository(PokiContext context): base(context)
    {

    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }

    public groups GetGroupWithParticipants(int id)
    {
      return PokiContext.groups.Include(a => a.participants).SingleOrDefault(a => a.ID == id);
    }
    public GroupsWithNumberOfParticipants GetGroupWithNumber(int id)
    {

      var grupa = PokiContext.groups.Include(a=> a.participants).Where(a=> a.ID==id)
        .Select(a=> new GroupsWithNumberOfParticipants { Data = a.CreationDate, Name = a.Name, Number = a.participants.Count })
        .Single();


      return grupa;
    }
  }
}