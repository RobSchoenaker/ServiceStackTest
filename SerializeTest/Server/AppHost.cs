using ServiceStack;
using ServiceStack.Host;
using ServiceStack.MsgPack;
using ServiceStack.Text;
using ServiceStack.Validation;
using ServiceStack.Wire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
  public class AppHost : AppHostHttpListenerBase
  {
    public AppHost()
    : base("HttpListener Self-Host", typeof(AdvertisementService).Assembly) { }

    public override void Configure(Funq.Container container)
    {
      JsConfig.EmitCamelCaseNames = true;
      JsConfig.IncludeNullValues = true;
      JsConfig.DateHandler = DateHandler.ISO8601;

      Plugins.Add(new MsgPackFormat());
      Plugins.Add(new WireFormat());

      this.GlobalMessageRequestFilters.Add(ValidationFilters.RequestFilter);

      this.GlobalRequestFilters.Add((req, res, requestDto) =>
      {
        var basicRequest = req as BasicRequest;
        if (basicRequest != null && !basicRequest.Message.Tag.IsNullOrEmpty())
        {
          req.Items.Add("ApiKey", basicRequest.Message.Tag);
        }
      });
    }
  }
}
