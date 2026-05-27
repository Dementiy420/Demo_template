using System;
using System.Collections.Generic;

namespace Demo_entity.Models;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Price { get; set; }

    public float Weight { get; set; }

    public virtual ICollection<Specification> Specifications { get; set; } = new List<Specification>();
}
