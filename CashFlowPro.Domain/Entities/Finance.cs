namespace CashFlowPro.Domain.Entities;

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
    
    // Relacionamento com Tag uma Finança pode ter várias tags
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
  }

  public enum FinanceType
  {
    Income,
    Expense
  }
