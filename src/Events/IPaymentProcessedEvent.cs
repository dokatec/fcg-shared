namespace FCG.Shared.Events;

public interface IPaymentProcessedEvent
{
    Guid OrderId { get; }
    Guid UserId { get; }
    decimal Amount { get; }
    bool IsSuccess { get; }
}