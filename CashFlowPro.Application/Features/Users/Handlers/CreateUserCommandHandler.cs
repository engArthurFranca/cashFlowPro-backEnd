using MediatR;
using CashFlowPro.Application.Features.Users.Commands;
using CashFlowPro.Application.Common.Interfaces;

namespace CashFlowPro.Application.Features.Users.Handlers;


public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
{
  private readonly IApplicationDbContext _context;

  public CreateUserCommandHandler(IApplicationDbContext context) => _context = context;

  public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
  {
    var user = new Domain.Entities.User
    {
      Username = request.UserName,
      Email = request.Email,
      PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
      IsGuest = request.IsGuest
    };

    _context.Users.Add(user);
    await _context.SaveChangesAsync(cancellationToken);

    return user.Id;
  }
}