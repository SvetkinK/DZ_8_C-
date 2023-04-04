// Вход: прямоугольный двумерный массив.
//Найти строку с минимальной суммой элементов
//напр: вход 1 4 7 2   выход 1 строка
//           5 9 2 3
//           8 4 2 4
//           5 2 6 7
Console.Write($"Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
      arr[i, j] = new Random().Next(0, 10);

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

int SumRows(int[,] arr)
{
  int minsum = 9 * n;
  int posminsum = 0;
  int sum = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum = sum + arr[i, j];
    }
    //Console.WriteLine($"индекс строки {i} sum = {sum}");
    if (sum < minsum)
    {
      minsum = sum;
      posminsum = i;
      //Console.WriteLine($"минимальная сумма {minsum} на строке {posminsum}");
    }
  }
  return posminsum;
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = (SumRows(array) + 1);
Console.WriteLine($"{pos} строка");


