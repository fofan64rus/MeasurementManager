namespace Marya.MeasurementManager.DomainModel
{
    /// <summary>
    /// Базовый интерфейс для всех сущностей с идентификатором
    /// </summary>
    public interface IIdentity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        long Id { get; }
    }
}
