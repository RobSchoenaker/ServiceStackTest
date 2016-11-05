using Client.Interfaces;
using Funq;
using ServiceStack;
using ServiceStack.MsgPack;
using ServiceStack.Wire;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
  public class AppHost : AppHostBase
  {
    public AppHost()
    : base("Dummy", typeof(Program).Assembly) { }

    public override void Configure(Funq.Container container)
    {
      // MsgPack
      container.Register<IMsgPackBackendServiceClient>(c =>
      {
        var client = new MsgPackBackendServiceClient("http://localhost:1337/");
        client.ResponseFilter = response =>
        {
          Trace.WriteLine($"MsgPackBSC: [{client.Elapsed.TotalMilliseconds}msecs]  {response.ResponseUri} ({response.ContentLength} bytes)");
        };
        client.AddHeader("X-ApiKey", "Dummy");
        return client;
      }).ReusedWithin(ReuseScope.None);

      // Wire
      container.Register<IWireBackendServiceClient>(c =>
      {
        var client = new WireBackendServiceClient("http://localhost:1337/");
        client.ResponseFilter = response =>
        {
          Trace.WriteLine($"WireBSC: [{client.Elapsed.TotalMilliseconds}msecs]  {response.ResponseUri} ({response.ContentLength} bytes)");
        };
        client.AddHeader("X-ApiKey", "Dummy");
        return client;
      }).ReusedWithin(ReuseScope.None);
    }
  }

}
