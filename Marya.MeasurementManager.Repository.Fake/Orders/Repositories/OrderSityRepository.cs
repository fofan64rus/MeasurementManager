using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marya.MeasurementManager.DomainModel.Orders;
using Marya.MeasurementManager.DomainModel.Orders.Repositories;

namespace Marya.MeasurementManager.Repository.Fake.Orders.Repositories
{
    /// <summary>
    /// Реализация репозитория для городов
    /// </summary>
    internal class OrderSityRepository : IOrderSityRepository
    {
        public Task<IEnumerable<IOrderSity>> GetAllAsync()
        {
            return Task.FromResult(new List<IOrderSity>
            {
                new OrderSity {Id = 1, Name = "Москва" },
                new OrderSity {Id = 2, Name = "Санкт-Петербург" },
                new OrderSity {Id = 3, Name = "Саратов" },
                new OrderSity {Id = 4, Name = "Нижний Новгород" },
                new OrderSity {Id = 5, Name = "Казань" }
            }.OrderBy(x => x.Name).AsEnumerable());
        }
    }
}
