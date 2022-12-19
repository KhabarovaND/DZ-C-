int n = 4;
int[,] sqareMatrix = new int[n, n];//создаем массив 4х4
//переменная, значением которой мы будем заполнять массив, пока она не достигнет значения i*j
int temp = 1;
//переменные для хранения длин сторон прямоугольного (двумерного) массива.
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;//Сначала точке a[i][j] присваиваем значение temp. Это удобно тем, что если длина сторон равна 0, то мы не войдем в массив. Иначе в точку a[i][j] положим значение temp, 
  temp++;//инкреминируем его
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)//Если у нас верхняя сторона прямоугольника и мы не достигла правой стороны, то двигаемся вправо: ++j
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)//Если мы на правой стороне прямоугольника и не достигли нижней стороны, то двигаемся вниз: ++i
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)//Если мы на нижней стороне прямоугольника и не достигли левой стороны, то двигаемся влево: --j
    j--;
  else//Иначе двигаемся вверх: --i
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
