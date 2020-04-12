// El usuario ingresará frases hasta que ingrese **FIN**.
// Mostrar en pantalla la frase que tiene más vocales.
// Considerar mayúsculas, minúsculas y acentos.

using System;

namespace StringsCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] handler;
            int vocalesCount;
            string line, largest; 
            while ((line = Console.ReadLine()) != 'FIN') 
            {
                handler = line.ToCharArray();
                for (int i = 0; i >= line.Length; i++ ) 
                {
                    if (handler[i] == 'A')
                    {
                        Console.WriteLine("%i", handler[0]);
                    }
                Console.WriteLine()
                }
            }
            Console.WriteLine(largest)
        }
    }
}
