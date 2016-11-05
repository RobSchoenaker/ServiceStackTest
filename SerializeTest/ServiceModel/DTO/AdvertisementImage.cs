using ServiceStack.DataAnnotations;
using ServiceStack.Model;

namespace ServiceModel.DTO
{
  public partial class AdvertisementImage : IHasId<int>
  {
    public int Id { get; set; }
    public int IdAdvertisement { get; set; }
    public string Name { get; set; }
    public bool IsMain { get; set; }
    public int SequenceNumber { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    [Ignore]
    public string AdvertisementCode { get; set; }
  }
}
