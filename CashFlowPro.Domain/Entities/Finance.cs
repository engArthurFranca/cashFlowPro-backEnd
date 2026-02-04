namespace CashFlowPro.Domain.Entities
{
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
    
    // Tags relations
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
  }
}