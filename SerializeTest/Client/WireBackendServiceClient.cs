using Client.Interfaces;
using ServiceStack.MsgPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
  public class MsgPackBackendServiceClient : MsgPackServiceClient, IMsgPackBackendServiceClient
  {
    private Stopwatch stopWatch = Stopwatch.StartNew();

    public MsgPackBackendServiceClient(string baseUri) : base(baseUri) { }

    public TimeSpan Elapsed
    {
      get
      {
        return stopWatch.Elapsed;
      }
    }

  }
}
