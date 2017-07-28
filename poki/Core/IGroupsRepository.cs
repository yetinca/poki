using poki.Models;

namespace poki.Core
{
  public interface IGroupsRepository:IRepository<groups>
  {
    groups GetGroupWithParticipants(int id);
   GroupsWithNumberOfParticipants  GetGroupWithNumber(int id);

  }
}
