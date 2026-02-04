using MediatR;

public record CreateUserCommand(
  string UserName,
  string Email,
  string Password,
  bool IsGuest = false
) : IRequest<int>;