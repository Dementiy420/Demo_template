using System;
using System.Collections.Generic;

namespace Demo_entity.Models;

public partial class Order
{
    public int Id { get; set; }

    public int SalesmanId { get; set; }

    public int ProductId { get; set; }

    public DateOnly Date { get; set; }

    public int Valueproduct { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Customer Salesman { get; set; } = null!;
}
