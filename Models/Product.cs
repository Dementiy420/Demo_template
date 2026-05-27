using System;
using System.Collections.Generic;

namespace Demo_entity.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Specification> Specifications { get; set; } = new List<Specification>();
}
