using System;
using System.Collections.Generic;

namespace Demo_entity.Models;

public partial class Specification
{
    public int Id { get; set; }

    public int CustomersId { get; set; }

    public int ProductId { get; set; }

    public int MaterialId { get; set; }

    public virtual Customer Customers { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
