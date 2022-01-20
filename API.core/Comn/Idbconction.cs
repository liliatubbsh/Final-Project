using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace API.core.Comn
{
  public  interface Idbconction
    {
        public DbConnection comm { get; }
    }
}
