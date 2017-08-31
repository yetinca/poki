using System.Collections.Generic;
using poki.Models;

namespace poki.Core
{
  public interface IParticipantsinGroupRepository:IRepository<ParticipantsInGroup>
  {
    IEnumerable<Participants> GetAvailableParticipants(int ID);
    ParticipantsInGroup GetByPeselAndGroupID(string pesel, int groupID);
  }
}
