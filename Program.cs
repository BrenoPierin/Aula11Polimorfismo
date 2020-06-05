using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           Calcular player = new Calcular();

           System.Console.WriteLine(player.calcular());

           System.Console.WriteLine(player.calcular(100));

           System.Console.WriteLine(player.calcular(100 , 75));
            
        }
    }
}
