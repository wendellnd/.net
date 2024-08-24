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
            var modelo = new HelloModelo();

            modelo.Hello();
        }
    }
}
