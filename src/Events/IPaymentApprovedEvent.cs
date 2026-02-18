namespace FCG.Shared.Events;

public interface IPaymentApprovedEvent
{
    Guid OrderId { get; }
    Guid UserId { get; }
    Guid GameId { get; }
    string Status { get; }
    DateTime ProcessedAt { get; }
}