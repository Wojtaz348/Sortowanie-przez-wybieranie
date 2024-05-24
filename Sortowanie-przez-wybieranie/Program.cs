using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj długość tablicy: ");
        int length = Convert.ToInt32(Console.ReadLine());

        // Generowanie tablicy losowych liczb
        int[] array = GenerateRandomArray(length);

        // Wyświetlanie początkowej tablicy
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(array);

        // Sortowanie tablicy za pomocą algorytmu sortowania przez wybór
        SortByChoice(array);

        // Wyświetlanie posortowanej tablicy
        Console.WriteLine("\nTablica po sortowaniu:");
        PrintArray(array);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 101); // Losowe liczby od 1 do 100
        }

        return array;
    }

    static void SortByChoice(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Zamiana minimalnego elementu z pierwszym elementem tablicy
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
