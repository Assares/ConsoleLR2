/// <copyright file="IContainer.cs"company="VS">
/// Все права защищены
/// </copyright>
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    /// <summary>
    /// Интерфейс контейнера
    /// </summary>
    /// <typeparam name="TElement"> Тип </typeparam>
    interface IContainer<TElement>
    {
        /// <summary>
        /// Получение количества элементов в контейнере
        /// </summary>
        Int32 Count
        {
            get;
        }
        /// <summary>
        /// Перегрузка квадратных скобок
        /// </summary>
        /// <param name="index"> Индекс элемента в контейнере </param>
        /// <returns> Элемента контейнера </returns>
        TElement this[int index]
        {
            get;
            set;
        }
        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="element)"> Элемент на добавление </param>
        void Add(TElement element);
        /// <summary>
        /// Удаление элемента 
        /// </summary>
        /// <param name="element)"> Элемент на удаление </param>
        void Delete(TElement element);
    }
}
