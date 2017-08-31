using System;
using poki.Core;
using poki.Models;

namespace poki
{
  public class UnitOfWork:IUnitOfWork

  {
    private bool _disposed;

    private readonly PokiContext _context;

    public UnitOfWork(PokiContext context)
    {
      _context = context;
      Participants = new ParticipantRepository(_context);
      Groups = new GroupsRepository(_context);
      ParticipantsInGroup = new ParticipantsInGroupRepository(_context);
      Results = new ResultsRepository(_context);
      ProperResultsQuestion = new ProperResultsQuestionRepository(_context);
      ProperResults = new ProperResultRepository(_context);
      Question = new QuestionRepository(_context);
      

    }
    
      public IParticipantRepository Participants { get; private set; }
      public IGroupsRepository Groups { get; private set; }
      public IParticipantsinGroupRepository ParticipantsInGroup { get; private set; }
      public IResultsRepository Results { get; private set; }
    public IProperResultRepository ProperResults { get; private set; }
    public IProperResultsQuestionRepository ProperResultsQuestion { get; private set; }
    public IQuestionRepository Question { get; private set; }
    

    public void Save()
    {
      _context.SaveChanges();
    }

    private void Dispose(bool disposing)
    {
      if (_disposed == false)
      {
        if (disposing)
        {
          _context.Dispose();
        }
      }
      _disposed = true;
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}