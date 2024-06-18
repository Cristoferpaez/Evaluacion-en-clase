using System;

class Program
{
    static void Main()
    {
        // Arreglo para almacenar los números
        double[] numeros = new double[10];

        // Solicitar al usuario que ingrese los números
        Console.WriteLine("Ingrese 10 números para ordenar:");

        // Ciclo para capturar los números ingresados por el usuario
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            // Leer la entrada del usuario como cadena
            string input = Console.ReadLine();

            // Intentar convertir la cadena a un número double
            if (double.TryParse(input, out double numero))
            {
                numeros[i] = numero; // Almacenar el número convertido
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                i--; // Decrementar i para repetir la entrada para este índice
            }
        }

        // Llamar a la función para ordenar los números
        OrdenarNumeros(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("\nNúmeros ordenados:");
        foreach (var numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    // Función para ordenar los números usando Selection Sort
    static void OrdenarNumeros(double[] numeros)
    {
        int n = numeros.Length;

        // Recorrer todos los elementos del arreglo
        for (int i = 0; i < n - 1; i++)
        {
            // Encontrar el mínimo elemento restante en la lista desordenada
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (numeros[j] < numeros[min_idx])
                {
                    min_idx = j;
                }
            }

            // Intercambiar el mínimo encontrado con el primer elemento desordenado
            double temp = numeros[min_idx];
            numeros[min_idx] = numeros[i];
            numeros[i] = temp;
        }
    }
}

