
void GreatArr(int[,] arr)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr1 = new int[m, n];
GreatArr(arr1);
int[,] arr2 = new int[m, n];
GreatArr(arr2);
int[,] arrNew = new int[m, n];

Console.WriteLine("Новый массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arrNew[i, j] = arr1[i, j] * arr2[i, j];
        Console.Write(arrNew[i, j] + " ");
    }
    Console.WriteLine();
}