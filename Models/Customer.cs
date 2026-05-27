using System;
using System.Collections.Generic;

namespace Demo_entity.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Inn { get; set; }

    public string Addres { get; set; } = null!;

    public string Salesman { get; set; } = null!;

    public string Buyer { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Specification> Specifications { get; set; } = new List<Specification>();
}
