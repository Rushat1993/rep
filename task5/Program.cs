//№ 62
int n = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < n - 1)
    j++;
  else if (i < j && i + j >= n - 1)
    i++;
  else if (i >= j && i + j > n - 1)
    j--;
  else
    i--;
}

  for (i = 0; i < n; i++)
  {
    for (j = 0; j < n; j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }