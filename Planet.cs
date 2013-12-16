/// <copyright file="Planet.cs"company="VS">
/// Все права защищены
/// </copyright>
namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    /// <summary>
    /// Клас планета
    /// </summary>
    class Planet
    {
        /// <summary>
        /// Имя Планеты
        /// </summary>
        private string name;
        /// <summary>
        /// Размер планеты
        /// </summary>
        private int size;
        /// <summary>
        /// Есть ли спутник у планеты
        /// </summary>
        private bool sattelite;
	    /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Planet"/>
        /// </summary>
        public Planet() 
        {
        }
	    
	/// <param name="weight"> Имя планеты </param>
	/// <param name="numberOfPlanets"> Размер планет </param>
	/// <param name="life"> Спутник </param>
        public Planet(string name, int size, bool sattelite) 
        {
            this.name = name;
            this.size = size;
            this.sattelite = sattelite;
        }
        /// <summary>
        /// Получает или задает Имя планеты
        /// </summary>
        public string Name 
        {
            get 
            {
                return this.name;
            }
            
            set 
            {
                this.name = value;
            }
        }
        /// <summary>
        /// Получает или задает Размер планет
        /// </summary>
        public int Size 
        {
            get 
            {
                return this.size;
            }

            set 
            {
                this.size = value;
            }
        }
        /// <summary>
        /// Получает или задает наличие спутника у планеты
        /// </summary>
        public bool Sattelite 
        {
            get 
            {
                return this.sattelite;
            }

            set 
            {
                this.sattelite = value;
            }
        }
        /// <summary>
        /// Перегрузка метода
        /// </summary>	
	/// <returns> Строка с описанием Планеты </returns>
        public override string ToString() 
        {
            return this.name.ToString() + " " + this.size.ToString() + " " + (this.sattelite ? "True" : "False");
        }
    }    
}
