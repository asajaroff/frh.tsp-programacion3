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
            //int vocalesCount;
            string line, largest; 
            Console.WriteLine("Ingrese un string: \n");
            while ((line = Console.ReadLine()) != "FIN") 
            {
                int vocalesCount = 0;
                foreach (char c in line)
                {
                    char lowercased = char.ToLower(c);
                    Console.WriteLine($"{lowercased}");
                    
                    if (lowercased == 'a' || lowercased == 'e'|| lowercased == 'i'|| lowercased == 'o'|| lowercased == 'u')
                    {
                        vocalesCount++;
                    }
                }
                Console.WriteLine($"Cantidad de vocales: {vocalesCount}");
            }
            //Console.WriteLine(largest);
        }
    }
}
