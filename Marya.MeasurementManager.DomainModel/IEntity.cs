namespace Marya.MeasurementManager.DomainModel
{
    /// <summary>
    /// Базовый интерфейс для всех сущностей
    /// </summary>
    public interface IEntity<T> : IIdentity where T : IIdentity
    {
    }
}
