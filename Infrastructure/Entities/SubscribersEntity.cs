using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class SubscribersEntity
{
	[Key]
	[Required]
	public string Email { get; set; } = null!;

}
