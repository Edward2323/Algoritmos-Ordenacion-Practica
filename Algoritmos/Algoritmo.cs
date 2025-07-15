namespace Algoritmos_Ordenacion_Practica.Algoritmos
{
    public class Algoritmo
    {
        protected static int[]? DefinirArreglo()
        {
            try
            {
                int size;
                int valor;
                int[] arreglo;

                Console.Write("Tamaño del array: ");
                size = Convert.ToInt32(Console.ReadLine());
                arreglo = new int[size];

                Console.WriteLine("Inserte valores \n");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"{i} = ");
                    valor = Convert.ToInt32(Console.ReadLine());

                    arreglo[i] = valor;
                }

                return arreglo;
            }
            catch
            {
                Console.WriteLine("Inserte los valores correctamente");
                return null;
            }
        }

        protected static void ImprimirArreglo(int[] arreglo)
        {
            foreach (int nota in arreglo)
            {
                Console.Write(nota + " ");
            }
            Console.WriteLine();
        }
    }
}
