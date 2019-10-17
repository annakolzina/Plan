using System.Collections.Generic;

namespace Univer.PlanTask.Core.Store
{
    /// <summary>
    /// Интерфейс базового хранилища
    /// </summary>
    public interface IBaseStore
    {
        /// <summary>
        /// Получить объект по идентификатору
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <returns>Объект</returns>
        IEntity Get(long Id);

        /// <summary>
        /// Создать сущность
        /// </summary>
        /// <param name="model">Сущность</param>
        void Create(IEntity model);

        /// <summary>
        /// Удалить сущность по идентификатору
        /// </summary>
        /// <param name="Id">Идентификатор</param>
        /// <returns>True, если удаление прошло успешно</returns>
        bool Delete(long Id);

        /// <summary>
        /// Обновить сущность
        /// </summary>
        /// <param name="model">Сущность</param>
        void Update(IEntity model);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns>Перечисление сущностей</returns>
        IEnumerable<IEntity> GetAll();

        /// <summary>
        /// Найти сущности по заданным условиям
        /// </summary>
        /// <param name="args">Условия</param>
        /// <returns>Перечисление сущностей</returns>
        IEnumerable<IEntity> Find(string[] args);
    }
}
