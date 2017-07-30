using poki.Models;

namespace poki.Core
{
  public interface IGroupsRepository:IRepository<Groups>
  {
    Groups GetGroupWithParticipants(int id);
   GroupsWithNumberOfParticipants  GetGroupWithNumber(int id);

  }
}
