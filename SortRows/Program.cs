// Задать двумерный массив.
//Упорядочить по убыванию элементы каждой строки.
//напр: вход 1 4 7 2  выход 7 4 2 1
//           5 9 2 3        9 5 3 2
//           8 4 2 4        8 4 4 2
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

void SortRows(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int max = j;
      for (int k = j + 1; k < array.GetLength(1); k++)
      {
        if (array[i, k] > array[i, max]) max = k;
      }

      int temp = array[i, j];
      array[i, j] = array[i, max];
      array[i, max] = temp;
    }
  }
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortRows(array);
PrintArray(array);