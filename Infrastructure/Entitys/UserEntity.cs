﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entitys;

public class UserEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string SecurityKey { get; set; } = null!;
    public string? Phone {  get; set; } = null!;
    public string? Biography { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Updated { get; set;}
    // Skapar en en till många relation
    public ICollection<AddressEntity> Address { get; set; } = new List<AddressEntity>();
}
