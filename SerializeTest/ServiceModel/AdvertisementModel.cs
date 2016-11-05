using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
  [Route("/advertisement/list", Verbs = "GET, POST", Summary = "Opvragen lijst met advertenties")]
  public class GetAdvertisements : RequestList, IReturn<ResponseList<DTO.Advertisement>>
  {
    public DateTime? EndDate { get; set; }
    public int? IdAction { get; set; }
    public int? IdAdvertisementState { get; set; }
    public int? IdCustomer { get; set; }
    public DateTime? StartDate { get; set; }
  }
}
