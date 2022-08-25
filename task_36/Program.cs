// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(1,1000);
    }  
    return arr;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
       else Console.WriteLine($"{arr[i]}]");
    }
}
int SummOfUnevenIndex(int[] arr) 
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) result += arr[i];
    }
    return result;
}
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length);
PrintArray(array);
Console.WriteLine(SummOfUnevenIndex(array));