using Marya.MeasurementManager.DomainModel.Orders;

namespace Marya.MeasurementManager.Repository.Fake.Orders
{
    /// <summary>
    /// Реализация города для хранения в репозиториях
    /// </summary>
    internal class OrderSity : IOrderSity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
