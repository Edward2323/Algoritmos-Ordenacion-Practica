namespace Algoritmos_Ordenacion_Practica.Algoritmos
{
    public class InsertionSort : Algoritmo
    {
        // Arreglo que contiene los tiempos de llegada
        private static int[]? tiempos;

        public static void Ordenar()
        {
            // Definir el arreglo de entrada
            tiempos = DefinirArreglo();

            // Mostrar el arreglo inicial
            Console.WriteLine("Tiempos iniciales:");
            ImprimirArreglo(tiempos);
            Console.WriteLine();

            // Inicializar contadores
            int comparaciones = 0;
            int intercambios = 0;

            int n = tiempos.Length;

            // Bucle que recorre cada elemento a partir del segundo
            for (int i = 1; i < n; i++)
            {
                int actual = tiempos[i]; // Valor que se quiere insertar ordenadamente
                int j = i - 1;

                Console.WriteLine($"Insertando el elemento en posición {i} (valor: {actual})");

                // Mover hacia la derecha los elementos mayores que 'actual'
                while (j >= 0)
                {
                    comparaciones++; // Registrar comparación

                    if (tiempos[j] > actual)
                    {
                        tiempos[j + 1] = tiempos[j]; // Desplazar el valor
                        j--;
                        intercambios++; // Registrar desplazamiento como intercambio
                    }
                    else
                    {
                        break; // Ya está en la posición correcta
                    }
                }

                // Insertar el valor en su posición correcta
                tiempos[j + 1] = actual;

                // Mostrar el arreglo después de la iteración
                Console.WriteLine($"Después de la iteración {i}:");
                ImprimirArreglo(tiempos);
                Console.WriteLine();
            }

            // Mostrar totales de comparaciones e intercambios (movimientos)
            Console.WriteLine($"Total de comparaciones: {comparaciones}");
            Console.WriteLine($"Total de intercambios (movimientos): {intercambios}");
        }
    }
}
