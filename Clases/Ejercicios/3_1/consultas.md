## Arrays
*   `double[] Array = new double[5];` Carga del 0 al 4 o del 1 al 5?

## Foreach
*   No puedo iterar a traves de `item`
```c#
            foreach (int item in ArrayV)
            {
                ArrayV[i] = Math.Pow((Array[i] - Promedio), 2);
                Varianza = Varianza + ArrayV[i];
                i++;
            }
```