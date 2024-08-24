using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapHelloWorld.Modelo;

namespace FiapHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            double valueDouble = 10.5;
            bool valueBool = true;
            string name = "Fiap";
            var n = "Fiap";

            value += 1;
            
            Console.WriteLine(value);

            string[] values = { "a", "b", "c" };

            IList<string> list = new List<string>();
            list.Add("Item")
            list.Insert(1, "Inserted Item");

            var modelo = new HelloModelo();

            modelo.Hello();
        }
    }
}
