using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class AbstractHandler
    {
        /// <summary>
        /// создание абстрактного метода открытие 
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// создание абстрактного метода создание
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// создание абстрактного метода изменение
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// создание абстрактного метода сохранение 
        /// </summary>
        public abstract void Save();
    }
}
