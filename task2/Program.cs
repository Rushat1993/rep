Console.Write("Введите размер массива m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = new Random().Next(0, 100);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

int SumStr = 0, Str = 0;

for (int i = 0; i < m; i++)
{
    int Sum = 0;
    for (int j = 0; j < n; j++)
    {
        Sum = Sum + arr[i, j];
    }
//    Console.WriteLine($"Строка {i + 1}, сумма {Sum}");
    if (SumStr > Sum || i == 0)
    {
        SumStr = Sum;
        Str = i;
    }

}
Console.WriteLine($"Строка с наименьшей суммой {Str + 1}");