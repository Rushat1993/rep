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

for (int i = 0; i < m; i++)
{
for (int j = 1; j < n;)
{
if (arr[i, j - 1] > arr[i, j])
{
int min = arr[i, j];
arr[i, j] = arr[i, j - 1];
arr[i, j - 1] = min;
j = 1;
}
else
{ j++; }
}
}

Console.WriteLine("Новый массив: ");
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
Console.Write(arr[i, j] + " ");
}
Console.WriteLine();
}