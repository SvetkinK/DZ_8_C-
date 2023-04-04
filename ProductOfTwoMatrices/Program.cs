// Задать две матрицы. Найти произведение двух матриц
//напр вход 2 4 и 3 4  выход 18 20
//          3 2   3 3        15 18
Console.Write($"Введите кол-во строк матрицы1 ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов матрицы1 ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во строк матрицы2 ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов матрицы2 ");
int q = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
      arr[i, j] = new Random().Next(0, 5);
}

void PrintArray(int[,] ar)
{
  for (int i = 0; i < ar.GetLength(0); i++)
  {
    for (int j = 0; j < ar.GetLength(1); j++)
      Console.Write($"{ar[i, j],2}\t");
    Console.WriteLine();
  }
}


int[,] array1 = new int[m, n];
Console.WriteLine("array1");
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = new int[p, q];
Console.WriteLine("array2");
FillArray(array2);
PrintArray(array2);
Console.WriteLine();

if (n != p)
{
  Console.WriteLine($"Умножение невозможно");
}
else
{
  int[,] product = new int[m, q];
  {
    for (int i = 0; i < m; i++)
      for (int j = 0; j < q; j++)
      {
        product[i, j] = 0;
        for (int k = 0; k < n; k++)
        {
          product[i, j] += array1[i, k] * array2[k, j];
        }
      }
  }
  PrintArray(product);
}


