namespace FCG.Shared.Events;

public interface IOrderPlacedEvent
{
    Guid OrderId { get; }
    Guid UserId { get; }
    Guid GameId { get; }
    decimal Price { get; }
}