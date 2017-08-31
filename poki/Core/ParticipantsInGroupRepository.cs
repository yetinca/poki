using System.Collections.Generic;
using System.Linq;
using poki.Models;

namespace poki.Core
{
  public class ParticipantsInGroupRepository: Repository<ParticipantsInGroup>, IParticipantsinGroupRepository
  {
    public ParticipantsInGroupRepository(PokiContext context) : base(context)
    {

    }
    public PokiContext PokiContext
    {
      get { return Context as PokiContext; }
    }
    public IEnumerable<Participants> GetAvailableParticipants(int ID)
    {
      var available = PokiContext.Participants.Where(a => !a.ParticipantsInGroup.Where(p => p.GroupsID == ID).Any());
        
      
      return available;

    }
    public ParticipantsInGroup GetByPeselAndGroupID(string pesel, int groupID)
    {
      var participant = PokiContext.ParticipantsInGroup.Where(a => a.Participants.PESEL == pesel && a.GroupsID == groupID).SingleOrDefault();

      return participant;
    }

   

  }
}