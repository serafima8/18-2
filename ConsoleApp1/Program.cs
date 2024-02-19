using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> handlers = new List<AbstractHandler>();
            while(true)
            {
                Console.Write("Введите формат: ");
                string format = Console.ReadLine();
                switch(format)
                {
                    case "XML":
                        AbstractHandler xml = new XMLHandler();
                        xml.Open();
                        xml.Create();
                        xml.Change();
                        xml.Save();
                        break;
                    case "TXT":
                        AbstractHandler txt = new TXTHandler();
                        txt.Open();
                        txt.Create();
                        txt.Change();
                        txt.Save();
                        break;
                    case "DOC":
                        AbstractHandler doc = new DOCHandler();
                        doc.Open();
                        doc.Create();
                        doc.Change();
                        doc.Save();
                        break;

                    case "a":return;
                    default: Console.WriteLine("формата не существует");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
