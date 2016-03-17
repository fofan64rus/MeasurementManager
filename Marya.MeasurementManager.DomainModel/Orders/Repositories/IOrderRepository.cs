using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marya.MeasurementManager.DomainModel.Orders.Repositories
{
    /// <summary>
    /// Репозиторий для заказов замеров
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Получить все заказы, для которых еще не назначена дата замера
        /// </summary>
        Task<IEnumerable<IOrder>> GetAllWithoutDateAsync();

        /// <summary>
        /// Запланировать замер на дату
        /// </summary>
        /// <param name="order">Идентификатор заказа замера</param>
        /// <param name="orderCapacity">Идентификатор выбранной возможности замера</param>
        Task<IOrder> PlanOrder(IEntity<IOrder> order, IEntity<IOrdersCapacity> orderCapacity);
    }
}
