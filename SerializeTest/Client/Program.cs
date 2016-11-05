using Client.Interfaces;
using ServiceModel;
using ServiceStack;
using ServiceStack.MsgPack;
using ServiceStack.Text;
using ServiceStack.Wire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
  class Program
  {
    static void Main(string[] args)
    {
      var appHost = new AppHost();
      appHost.Init();

      Console.WriteLine("JSON");
      using (var client = new JsonServiceClient("http://localhost:1337/"))
      {

        var request = new GetAdvertisements
        {
          Skip = 0,
          Take = 7,
        };

        var response = client.Get(request);
        Console.WriteLine(response.Items.Dump());
      }

      Console.WriteLine("MsgPack");
      using (var client = HostContext.Resolve<IMsgPackBackendServiceClient>())
      {

        var request = new GetAdvertisements { Skip = 0, Take = 7 };

        var response = client.Get(request);
        Console.WriteLine(response.Items.Dump());
      }

      Console.WriteLine("Wire");
      using (var client = HostContext.Resolve<IWireBackendServiceClient>())
      {

        var request = new GetAdvertisements { Skip = 0, Take = 7 };

        var response = client.Get(request);
        Console.WriteLine(response.Items.Dump());
      }

      Console.ReadKey();
    }
  }
}
