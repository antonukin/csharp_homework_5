// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Math.Round((rnd.NextDouble() * 100), 1);
        }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

(double, double, double) FindMaxMinDiff(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    double diff = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max)
        {
            max = numbers[i];
        }
        if(numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    diff = max - min;
return (max, min, diff);
}

Console.WriteLine("Введите длину массива");
int length = Int32.Parse(Console.ReadLine());
double[] newArray = new double[length];
FillArray(newArray);
PrintArray(newArray);
Console.WriteLine();
(double arrMax, double arrMin, double arrDiff) = FindMaxMinDiff(newArray);
Console.WriteLine($"Разница между максимальным элементом {arrMax} и минимальным {arrMin} равна {Math.Round(arrDiff, 1)}");