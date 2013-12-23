/// <copyright file="PlanetContainer.cs"company="VS">
/// Все права защищены
/// </copyright>
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.ComponentModel;
    using System.IO;
    class PlanetContainer: BindingList<Planet>, IFileContainer<Planet>, IEnumerable 
    {
        /// <summary>
        /// Проверка на сохранение данных
        /// </summary>
        private bool isDataSaved;

	
	    /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PlanetContainer"/>
        /// </summary>
        public PlanetContainer() 
        {
            this.isDataSaved = true;
        }

	/// <summary>
        /// Делегат Планеты
        /// </summary>
	    /// <param name="sender"> Жизнь </param>
	    /// <param name="isDataSaved"> Сохранение данных </param>
        public delegate void PLEventHandler(object sender, bool isDataSaved);
        
	    /// <summary>
        /// Событие делегата
        /// </summary>
	public event PLEventHandler StateChanged;

	/// <summary>
        /// Получает количество элементов в контейнере
        /// </summary>
        public int Count 
        {
            get 
            {
                return base. Count;
            }
        }

	/// <summary>
        /// Получает или задает сохранение данных
        /// </summary>
        public bool IsDataSaved {
            get 
            {
                return this.isDataSaved;
            }

            set 
            {
                this.isDataSaved = value;
            }
        }

	
	/// <summary>
        /// Добавление элемента в контейнер
        /// </summary>
	/// <param name="star"> Обьект класса Planet </param>
        public new void Add(Planet PL) 
        {
            base.Add(PL);
            this.OnSaveData(false);
        }

	/// <summary>
        /// Удаление элемента из контейнера
        /// </summary>
        /// <param name="star"> Обьект класса Planet </param>
        public void Delete(Planet PL) 
        {
            this.Remove(PL);
            this.OnSaveData(false);
        }

	/// <summary>
        /// Проверка состояния сохранения
        /// </summary>
	/// <param name="sender"> Объект </param>
	/// <param name="isDataSaved"> Сохранения контейнера </param>
        public void saveData(object sender, bool isDataSaved) {
            this.isDataSaved = isDataSaved;
        }

	/// <summary>
        /// Загрузка из файла
        /// </summary>
	/// <param name="fileName"> Имя файла </param>
        public void Load(string fileName) 
        {
            this.Clear();
            string[] line;
            string[] fileLines = File.ReadAllLines(fileName);
            for (int i = 0; i < fileLines.Length; i++) 
            {
                    line = fileLines[i].Split(' ');
                    this.Add(new Planet( line[0], int.Parse(line[1]), line[2].Equals("True"))); 
            }
        }

	/// <summary>
        /// Задание состояния контейнера
        /// </summary>
	/// <param name="state"> Изменения состояния контейнера </param>
        public void OnSaveData(bool state) 
        {
            if (this.StateChanged != null)
                this.StateChanged(this, state);
        }

	/// <summary>
        /// Сохранение контейнера в файл
        /// </summary>
	/// <param name="fileName"> Имя файла </param>
        public void Save(string fileName) 
        {
            using (StreamWriter outfile = new StreamWriter(fileName)) 
            {
                for (int i = 0; i < base.Count; i++) 
                {
                    outfile.Write(this[i].ToString() + "\r\n");
                }
            }

            this.OnSaveData(true);
        }

	
	/// <summary>
        /// Перегрузка метода
        /// </summary>
	/// <returns> Строка с описанием звезды </returns>
        public override string ToString() 
        {
            StringBuilder line = new StringBuilder();
            foreach (Planet item in this.Items) 
            {
                if (item != null) 
                {
                    line.Append("Name of planets = ").Append(item.Name).Append("\r\nSize of planets = ").Append(item.Size).Append("\r\nHave sattelite = ").Append(item.Sattelite ? "yes" : "no").Append("\r\n\r\n");
                }
            }
            return line.ToString();
        }

	
	/// <summary>
        /// Получение итератора
        /// </summary>
	/// <returns> Элемент контейнера </returns>
        public new IEnumerator GetEnumerator() 
        {
            for (int i = 0; i < this.Count; i++)
                yield return this[i];
        }
    }
}
