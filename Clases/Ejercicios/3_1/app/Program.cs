using System;

namespace VarianzaYDesviacionEstandar
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Array = new double[5];
            int i = 0;
            
            Console.WriteLine("Ingrese 5 numeros:");

            foreach (int item in Array)
            {
                Array[i] = Convert.ToDouble(Console.ReadLine());
                i++;
            }
            // Imprimir Array
            // Console.WriteLine($"{Array[0]},{Array[1]},{Array[2]},{Array[3]},{Array[4]}");

            // Promedio
            double Promedio = 0;
            for (int l = 0; l < Array.Length ; l++)
            {
                Promedio = Promedio + Array[l];
            }
            Promedio = Promedio/Array.Length;
            Console.WriteLine($"Promedio: {Promedio}");

            // Varianza
            double[] ArrayV = new double[5];
            double Varianza = 0;

            i=0;
            foreach (int item in ArrayV)
            {
                ArrayV[i] = Math.Pow((Array[i] - Promedio), 2);
                Varianza = Varianza + ArrayV[i];
                i++;
            }
            Varianza = Varianza / ArrayV.Length;
            Console.WriteLine($"Varianza: {Varianza}");

            // Desviacion Estandar
            Console.WriteLine($"Desviación Estándar: {Math.Sqrt(Varianza)}");
        }
    }
}
