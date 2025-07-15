namespace Algoritmos_Ordenacion_Practica.Algoritmos
{
    public class BubbleSort : Algoritmo
    {
        // Arreglo que contiene las calificaciones
        private static int[]? notas;

        public static void Ordenar()
        {
            // Definir el arreglo de entrada
            notas = DefinirArreglo();

            // Mostrar el arreglo inicial
            Console.WriteLine("Calificaciones iniciales:");
            ImprimirArreglo(notas);
            Console.WriteLine();

            // Inicializar contadores
            int comparaciones = 0;
            int intercambios = 0;

            // Bucle principal para recorrer el arreglo varias veces
            for (int i = 0; i < notas.Length - 1; i++)
            {
                // Bucle interno para comparar elementos adyacentes
                for (int j = 0; j < notas.Length - i - 1; j++)
                {
                    comparaciones++; // Registrar una comparación

                    // Si el elemento actual es mayor al siguiente, se intercambian
                    if (notas[j] > notas[j + 1])
                    {
                        int temp = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = temp;
                        intercambios++; // Registrar un intercambio
                    }
                }

                // Mostrar el estado del arreglo después de cada pasada
                Console.WriteLine($"Después de la pasada {i + 1}:");
                ImprimirArreglo(notas);
                Console.WriteLine();
            }

            // Mostrar totales de comparaciones e intercambios
            Console.WriteLine($"Total de comparaciones: {comparaciones}");
            Console.WriteLine($"Total de intercambios: {intercambios}");
        }
    }
}
