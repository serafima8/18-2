using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Производный класс от базового класса AbstractHandler
    /// </summary>
    class DOCHandler : AbstractHandler
    {
        /// <summary>
        /// метод открытие
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Open document format: DOC");
        }
        /// <summary>
        /// метод создание
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Creat document format: DOC");
        }
        /// <summary>
        /// метод редактирование
        /// </summary>
        public override void Change()
        {
            Console.WriteLine("Change document format: DOC");
        }
        /// <summary>
        /// метод сохранение 
        /// </summary>
        public override void Save()
        {
            Console.WriteLine("Save document format: DOC");
        }
    }
}
