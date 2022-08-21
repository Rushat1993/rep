//№60
Console.Write("Введите размер массива m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива b ");
int b = Convert.ToInt32(Console.ReadLine());

int[,,] arr = new int[m, n, b];
Console.WriteLine("Массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int y = 0; y < b; y++)
        {
            bool Cont;
            int temp;
            do
            {
                temp = new Random().Next(0, 100);
                Cont = false;
                foreach (int item in arr)
                {
                    if (item == temp)
                    {
                        Cont = true;
                        break;

                    }
                }
            } while (Cont);
            arr[i, j, y] = temp;
            Console.Write(arr[i, j, y] + "(" + i + "," + j + "," + y + ") ");

        }
    Console.WriteLine();
    }
//    Console.WriteLine();
}