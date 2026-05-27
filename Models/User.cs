using System;
using System.Collections.Generic;

namespace Demo_entity.Models;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int CaptchaAttempts { get; set; }
}
