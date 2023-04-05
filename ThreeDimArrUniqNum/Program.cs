﻿// Сформировать трёхмерный массив из уникальных двузначных чисел.
//Вывести массив построчно, добавляя индексы каждого элемента
//напр массив размером 2 х 2 х 2
//    66(0,0,0) 25(0,1,0)
//    34(1,0,0) 41(1,1,0)
//    27(0,0,1) 90(0,1,1)
//    26(1,0,1) 55(1,1,1)


void PrintArray(int[,,] ar)
{
  for (int i = 0; i < 2; i++)
  {
    for (int j = 0; j < 2; j++)
    {
      for (int q = 0; q < 2; q++)
      {
        Console.Write($"{ar[i, j, q]} ({i},{j},{q})");
        Console.WriteLine();
      }
    }
  }
}

int[,,] array = new int[2, 2, 2]{
  {{64,27},{25,90}},
  {{34,26},{41,55}},
  };
PrintArray(array);