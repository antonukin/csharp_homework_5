// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

(int, int) FindSum(int[] arr)
{
    int evenSum = 0;
    int unevenSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 0)
        {
            evenSum += arr[i];
        }
        else
        {
            unevenSum += arr[i];
        }
    }
return (evenSum, unevenSum);
}

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
PrintArray(array);
Console.WriteLine();
(int even, int uneven) = FindSum(array);
Console.WriteLine($"Сумма элементов стоящих на четных позициях равна {even}, сумма элементов стоящих на нечетных позициях равна {uneven}");