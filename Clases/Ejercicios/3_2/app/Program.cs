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
            int vocalesCount=0, vocalesMax=0;
            string line, largest="none"; 
            Console.WriteLine("Ingresar frase: \n");
            while ((line = Console.ReadLine()) != "FIN") 
            {
                vocalesCount = 0;
                foreach (char c in line)
                {
                    char lowercased = char.ToLower(c);
                    if (lowercased == 'a' || lowercased == 'e'|| lowercased == 'i'|| lowercased == 'o'|| lowercased == 'u' ||
                        lowercased == 'à' || lowercased == 'è' ||  lowercased == 'ì' ||  lowercased == 'ò' || lowercased == 'ù' ||
                        lowercased == 'á' || lowercased == 'é' ||  lowercased == 'í' ||  lowercased == 'ó' || lowercased == 'ú' )
                    {
                        vocalesCount++;
                    }
                    if (vocalesCount > vocalesMax)
                    {
                        largest = line;
                        vocalesMax = vocalesCount;
                    }
                }
            }
        Console.WriteLine($"Frase con mas vocales:\t{largest}\nCantidad de vocales: \t{vocalesCount}");
        }
    }
}