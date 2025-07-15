

using Algoritmos_Ordenacion_Practica.Algoritmos;

while (true)
{
    try
    {
        int res = 4;
        Console.WriteLine(
            "Que algoritmo desea ejecutar \n" +
            "1.Bubble Sort \n" +
            "2.Selection Sort \n" +
            "3.Insertion Sort \n" +
            "4. Salir"
            );

        res = Convert.ToInt32(Console.ReadLine());

        if( res == 1)
        {
            BubbleSort.Ordenar();
        }

        else if ( res == 2)
        {
            SelectionSort.Ordenar();
        }

        else if (res == 3)
        {
            InsertionSort.Ordenar();
        }

        else if (res == 4)
        {
            break;
        }



    }
    catch
    {

    }
}