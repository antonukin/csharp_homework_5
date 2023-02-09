// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

void FillArray(int[] arr, int dimention)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

(int, int) EvenAndUnevenCount (int[] arr)
{
    int evenCount = 0;
    int unevenCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) evenCount++;
        else unevenCount++;
    }
return (evenCount, unevenCount);           
}

Console.WriteLine("Введите размер массива");
int dim = Convert.ToInt32(Console.ReadLine());
int[] array = new int[dim];
FillArray(array, dim);
PrintArray(array);
Console.WriteLine();

(int even, int uneven) = EvenAndUnevenCount(array);
Console.WriteLine($"Количество четных элементов массива равна {even}, количество нечетных элементов массива равна {uneven}");