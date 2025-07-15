namespace Algoritmos_Ordenacion_Practica.Algoritmos
{
    public class SelectionSort : Algoritmo
    {
        // Arreglo que contiene los precios
        private static int[]? precios;

        public static void Ordenar()
        {
            // Definir el arreglo de entrada
            precios = DefinirArreglo();

            // Mostrar el arreglo inicial
            Console.WriteLine("Precios iniciales:");
            ImprimirArreglo(precios);
            Console.WriteLine();

            // Inicializar contadores
            int comparaciones = 0;
            int intercambios = 0;

            int n = precios.Length;

            // Bucle externo para cada posición del arreglo
            for (int i = 0; i < n - 1; i++)
            {
                int indiceMin = i; // Suponemos que el mínimo está en la posición actual

                // Buscar el índice del valor mínimo en el resto del arreglo
                for (int j = i + 1; j < n; j++)
                {
                    comparaciones++; // Registrar una comparación
                    if (precios[j] < precios[indiceMin])
                    {
                        indiceMin = j; // Se encuentra un nuevo valor mínimo
                    }
                }

                // Mostrar el índice mínimo encontrado en esta iteración
                Console.WriteLine($"Índice mínimo en la iteración {i + 1}: {indiceMin}");

                // Si el mínimo no está en la posición actual, intercambiar
                if (indiceMin != i)
                {
                    int temp = precios[i];
                    precios[i] = precios[indiceMin];
                    precios[indiceMin] = temp;
                    intercambios++; // Registrar un intercambio
                }

                // Mostrar el arreglo después de cada iteración
                Console.WriteLine($"Después de la iteración {i + 1}:");
                ImprimirArreglo(precios);
                Console.WriteLine();
            }

            // Mostrar totales de comparaciones e intercambios
            Console.WriteLine($"Total de comparaciones: {comparaciones}");
            Console.WriteLine($"Total de intercambios: {intercambios}");
        }
    }
}
