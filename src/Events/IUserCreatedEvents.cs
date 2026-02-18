namespace FCG.Shared.Events;

public interface IUserCreatedEvent
{
    Guid UserId { get; }
    string Name { get; }
    string Email { get; }
    DateTime CreatedAt { get; }
}