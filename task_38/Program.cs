// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] FillArray(int len)
{
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(rnd.Next(1,101) + rnd.NextDouble(),2);
    }  
    return arr;
}
void PrintArray(double[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.WriteLine($"{arr[i]}]");
    }
}
double DiffOfMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    return max - min;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(length);
PrintArray(array);
Console.WriteLine(DiffOfMinMax(array));