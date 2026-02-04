using CashFlowPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlowPro.Application.Common.Interfaces;

public interface IApplicationDbContext
{
  DbSet<User> Users { get; }
  DbSet<Finance> Finances { get; }
  DbSet<Tag> Tags { get; }

  Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}