using MediatR;
using CashFlowPro.Domain.Entities;

public record CreateFinanceCommand(
  string Title,
  string Description,
  int Month,
  int Year,
  decimal Value,
  int NIstallments,
  bool Recurring,
  FinanceType FinanceType,
  int TagId
) : IRequest<int>;