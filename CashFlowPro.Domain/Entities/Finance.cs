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

  public class Finance
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal Value { get; set; }
    public int NIstallments { get; set; }
    public bool Recurring { get; set; }
    public FinanceType Type { get; set; }

    //Relacionamento com Usuário
    public int UserId { get; set; }
    public User? User { get; set; }
    
    // relAnciamento com Tag
    public int TagId { get; set; }
    public Tag? Tag { get; set; }
  }

  public enum FinanceType
  {
    Income,
    Expense
  }

  public class Tag
  {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;

    //Chave estrangeira para o usuário
    public int UserId { get; set; }
    public User? User { get; set; }
  }
