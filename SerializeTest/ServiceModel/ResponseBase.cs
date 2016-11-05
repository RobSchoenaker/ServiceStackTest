using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
  public class ResponseBase : IHasResponseStatus
  {
    public ResponseBase() { }

    public ResponseStatus ResponseStatus { get; set; }
  }
}
