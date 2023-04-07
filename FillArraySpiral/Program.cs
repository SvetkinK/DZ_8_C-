// Заполнить спирально массив 4 х 4
// напр 01 02 03 04
//      12 13 14 05
//      11 16 15 06
//      10 09 08 07

Console.Write($"Введите кол-во строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите кол-во столбцов ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(string[,] ar)
{
  for (int i = 0; i < ar.GetLength(0); i++)
  {
    for (int j = 0; j < ar.GetLength(1); j++)
      Console.Write($"{ar[i, j],2}\t");
    Console.WriteLine();
  }
}

string[,] Spiral = new string[m, n];
int num = 00;

for (int j = 0; j < n; j++)           //int i = 0;                       //1-я горизонтальная
{
  int i = 0;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}

for (int i = 1; i < m; i++)            //int j = n - 1;                       //2-я последняя вертикальная    
{
  int j = n - 1;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}

for (int j = n - 2; j >= 0; j--)         //int i = m - 1;                     //3-я последняя горизонтальная
{
  int i = m - 1;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}

for (int i = m - 2; i > 0; i--)          //int j = 0;                   //4-я первая  вертикальная
{
  int j = 0;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}

for (int j = 1; j < n - 1; j++)          // int i = 1;                   //5-я вторая горизонтальная
{
  int i = 1;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}

for (int i = 2; i < m - 1; i++)            //int j = n - 1;                       //6-я предпоследняя вертикальная    
{
  int j = n - 2;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}

for (int j = n - 3; j > 0; j--)          //int i = m - 2;                   //7-я третья горизонтальная
{
  int i = m - 2;
  num = num + 1;
  string b = Convert.ToString(num).PadLeft(2, '0');
  Spiral[i, j] = b;
}
Console.WriteLine();
PrintArray(Spiral);

