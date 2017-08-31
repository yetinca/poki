using System;
using poki.Core;
namespace poki
{
  public interface IUnitOfWork: IDisposable
  {
    IParticipantRepository Participants { get; }
    IGroupsRepository Groups { get; }
    IParticipantsinGroupRepository ParticipantsInGroup { get; }
    IResultsRepository Results { get; }
    IProperResultRepository ProperResults { get; }
    IProperResultsQuestionRepository ProperResultsQuestion { get; }
    IQuestionRepository Question { get; }

    void Save();

    new void Dispose();


  }
}