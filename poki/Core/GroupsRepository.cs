using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class GroupsRepository:Repository<Groups>, IGroupsRepository
  {
    public GroupsRepository(PokiContext context): base(context)
    {

    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }

    public Groups GetGroupWithParticipants(int id)
    {
      return PokiContext.Groups.Include(a => a.ParticipantsInGroup.Select(c=> c.Participants)).SingleOrDefault(a => a.ID == id);
    }
    public GroupsWithNumberOfParticipants GetGroupWithNumber(int id)
    {

      var grupa = PokiContext.Groups.Include(a=> a.ParticipantsInGroup).Where(a=> a.ID==id)
        .Select(a=> new GroupsWithNumberOfParticipants { Data = a.CreationDate, Name = a.Name, Number = a.ParticipantsInGroup.Count, ID=a.ID })
        .Single();


      return grupa;
    }

   public IEnumerable<Groups> GetGroupsNotDeleted()
    {
      var grupy = PokiContext.Groups.Where(a => a.IsDeleted == false);

      return grupy;
    }
  }
}