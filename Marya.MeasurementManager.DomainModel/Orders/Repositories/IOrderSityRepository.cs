using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marya.MeasurementManager.DomainModel.Orders.Repositories
{
    /// <summary>
    /// Репозиторий для городов
    /// </summary>
    public interface IOrderSityRepository
    {
        /// <summary>
        /// Получить все города
        /// </summary>
        Task<IEnumerable<IOrderSity>> GetAllAsync();
    }
}
