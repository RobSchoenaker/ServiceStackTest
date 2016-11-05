using ServiceStack.DataAnnotations;
using ServiceStack.Model;
using System;
using System.Collections.Generic;

namespace ServiceModel.DTO
{
  public partial class Advertisement : IHasId<int>
  {

    [AutoIncrement]
    public int Id { get; set; }
    public int IdCompany { get; set; }
    public string Code { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public int IdCategory { get; set; }
    public int IdAdvertisementState { get; set; }
    public int IdCustomer { get; set; }
    public int IdAction { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool AllowBids { get; set; }
    public decimal Price { get; set; }
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public string HouseNumberAddition { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public int IdCountry { get; set; }
    public string CategoryName { get; set; }
    public int? IdCategoryParent { get; set; }
    public int IdCustomeState { get; set; }
    public string CustomerFullName { get; set; }
    public string CustomerFullNameAlternative { get; set; }
    public string CustomerDisplayName { get; set; }
    [Ignore]
    public List<AdvertisementImage> Images { get; set; } = new List<AdvertisementImage>();

  }
}
