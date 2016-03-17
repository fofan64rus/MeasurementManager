using System;

namespace Marya.MeasurementManager.DomainModel.Orders
{
    /// <summary>
    /// Возможности замеров
    /// </summary>
    public interface IOrdersCapacity : IEntity<IOrdersCapacity>
    {
        /// <summary>
        /// Город, в котором возможен замер
        /// </summary>
        IOrderSity Sity { get; }

        /// <summary>
        /// Дата и время начала замера
        /// </summary>
        DateTime BeginDate { get; }

        /// <summary>
        /// Дата и время окончания замера
        /// </summary>
        DateTime EndDate { get; }

        /// <summary>
        /// Количество возможных замеров
        /// </summary>
        int Capacity { get; }
    }
}
