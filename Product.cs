using System;
using System.Collections.Generic;

namespace CardboardhqAPI;

public partial class Product
{
    public int Productid { get; set; }

    public string? Name { get; set; }

    public string? Cleanname { get; set; }

    public string? Imageurl { get; set; }

    public int? Categoryid { get; set; }

    public int? Groupid { get; set; }

    public string? Url { get; set; }

    public DateTime? Modifiedon { get; set; }

    public int? Imagecount { get; set; }

    public bool? Ispresale { get; set; }

    public DateOnly? Releasedon { get; set; }

    public string? Note { get; set; }

    public string? Description { get; set; }
}
