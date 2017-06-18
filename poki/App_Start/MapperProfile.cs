using AutoMapper;
using poki.Models.ModelsApp;
using poki.Models.ModelsDB;

namespace poki.App_Start
{
  public class MapperProfile: Profile
  {
    protected void Configure()
    {
      CreateMap<PersonsApp, Persons>();
      CreateMap<Persons, PersonsApp>();

    }

  }
}