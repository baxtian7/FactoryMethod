using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Aplicación para calcular nivel de embriaguez");
            Console.WriteLine("Ingrese 1 para Vino tinto o 2 para cerveza:");
            string bebida = Console.ReadLine();
            BebidasEmbriagantes oBebida = Creador.CreadorBebida(Convert.ToInt32(bebida));
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}
