/// <summary>
/// Перечисление вариаций статуса заказа.
/// </summary>
public enum OrderStatus
{
    New,
    Processing,
    Assembly,
    Sent,
    Delivered,
    Returned,
    Abandoned
}