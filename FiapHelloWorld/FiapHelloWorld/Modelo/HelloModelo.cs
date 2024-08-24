using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWorld.Modelo
{
    internal class HelloModelo
    {
        public string Message = "Hello, World!";

        public void Hello()
        {
            Console.WriteLine(Message);

            Console.Read();
        }
    }
}
