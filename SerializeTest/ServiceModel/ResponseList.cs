using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
  public class ResponseList<T> : ResponseBase
  {
    public ResponseList() { }

    public List<T> Items { get; set; }
    public long TotalCount { get; set; }
  }
}
