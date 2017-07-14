using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Logic
{
  public class SystemLogin
  {
    public SystemLogin()
    {

    }
    public string Get()
    {
      return (Environment.UserName);
    }
  }
}