using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using poki.Models;
using poki.Models.ViewModels;

namespace poki.App_Start
{
  public class AutoMapperConfig
  {
    public static MapperConfiguration Configuration { get; set; }

    public static IMapper Mapper
    {
      get
      {
        return Configuration.CreateMapper();

      }
    }

    public static void RegisterMappings()
    {
      Configuration = new MapperConfiguration(a =>
       {
         a.CreateMap<Participants, EditParticipant>();
         //.ForMember(d=> d.Name, o=>o.MapFrom(src=>src.NickName))
         a.CreateMap<EditParticipant, Participants>();
 
       });
    }
  }
}