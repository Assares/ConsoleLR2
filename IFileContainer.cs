/// <copyright file="IFileContainer.cs"company="VS">
/// Все права защищены
/// </copyright>
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    /// <summary>
    /// Интерфейс загрузки из файла
    /// </summary>
    /// <typeparam name="TElement"> Тип </typeparam>
    interface IFileContainer<TElement>: IContainer<TElement>
    {
        /// <summary>
        /// Сохранение в файл
        /// </summary>
        /// <param name="fileName"> Имя файла </param> 
        void Save(string fileName);
        /// <summary>
        /// Загрузка из файла
        /// </summary>
        /// <param name="fileName"> Имя файла </param> 
        void Load(string fileName);
        /// <summary>
        /// Проверка на сохранение документа
        /// </summary>
        Boolean IsDataSaved
        {
            get;
        }
    }
}
