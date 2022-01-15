using System.ComponentModel.DataAnnotations;

namespace Twittor.Dtos
{
  public class LockUserInput
  {
    [Required]
    public string Username { get; set; }
    [Required]
    public bool Lock { get; set; }
  }
}