namespace e_shop.Domain.Entities;

using System.ComponentModel.DataAnnotations;

public class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; }

    public string Privileges { get; set; }
}