namespace Marya.MeasurementManager.DomainModel.Orders
{
    /// <summary>
    /// Город, в котором можно заказать замер
    /// </summary>
    public interface IOrderSity : IEntity<IOrderSity>
    {
        /// <summary>
        /// Название города
        /// </summary>
        string Name { get; }
    }
}
