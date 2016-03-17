using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marya.MeasurementManager.DomainModel.Orders.Repositories
{
    /// <summary>
    /// Репозиторий для возможностей заказа замера
    /// </summary>
    public interface IOrderCapacityRepository
    {
        /// <summary>
        /// Получить все активные возможности замера
        /// </summary>
        /// <param name="sity">Город, в котором производится замер</param>
        /// <param name="fromDate">Дата начала периода поиска</param>
        /// <param name="toDate">Дата окончания периода поиска</param>
        Task<IEnumerable<IOrdersCapacity>> GetAllActive(IEntity<IOrderSity> sity, DateTime? fromDate = null, DateTime? toDate = null);
    }
}
