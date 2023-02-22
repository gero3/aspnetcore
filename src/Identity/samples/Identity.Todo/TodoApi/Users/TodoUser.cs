// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TodoApi;

// This is our TodoUser, we can modify this if we need
// to add custom properties to the user
public class TodoUser : IdentityUser { }

public class ExternalUserInfo
{
    [Required]
    public string Username { get; set; } = default!;

    [Required]
    public string ProviderKey { get; set; } = default!;
}

public class RefreshToken
{
    [Required]
    public string Token { get; set; } = default!;
}
