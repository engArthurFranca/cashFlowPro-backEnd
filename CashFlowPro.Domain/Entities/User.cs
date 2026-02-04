namespace CashFlowPro.Domain.Entities;

public class User
  {
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    //Usuário Guest
    public bool IsGuest { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    //Relacionamentos: Um usuário pode ter várias finanças e tags
    public ICollection<Finance> Finances { get; set; } = new List<Finance>();
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
  }