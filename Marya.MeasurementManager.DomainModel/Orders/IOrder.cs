using System;

namespace Marya.MeasurementManager.DomainModel.Orders
{
    /// <summary>
    /// Заказ замера
    /// </summary>
    public interface IOrder : IEntity<IOrder>
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        string Number { get; }

        /// <summary>
        /// ФИО клиента
        /// </summary>
        string ClientFullName { get; }

        /// <summary>
        /// Дата и время начала замера
        /// </summary>
        DateTime? BeginDate { get; }

        /// <summary>
        /// Дата и время окогчания замера
        /// </summary>
        DateTime? EndDate { get; }
    }
}
