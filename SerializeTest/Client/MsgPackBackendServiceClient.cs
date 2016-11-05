using Client.Interfaces;
using ServiceStack.Wire;
using System;
using System.Diagnostics;

namespace Client
{
  public class WireBackendServiceClient : WireServiceClient, IWireBackendServiceClient
  {
    private Stopwatch stopWatch = Stopwatch.StartNew();

    public WireBackendServiceClient(string baseUri) : base(baseUri) { }

    public TimeSpan Elapsed
    {
      get
      {
        return stopWatch.Elapsed;
      }
    }

  }
}
