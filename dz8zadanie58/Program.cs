// сначала создадим 2 матрицы
Console.WriteLine("Введите количество строк для матрицы 1  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы 1");
int b = Convert.ToInt32(Console.ReadLine());

double[,] firstMatrix = new double [a, b];//обявляем первую матрицу  с коллич.строк a и с коллич.столбцов b
////////////////////////////////////////////////////////////////////
Console.WriteLine("Введите количество строк для матрицы 2  ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для матрицы 2");
int z = Convert.ToInt32(Console.ReadLine());

double[,] secondMatrix = new double [c, z];//обявляем вторую матрицу с коллич.строк c и с коллич.столбцов z

double[,] matrixResalt = new double [a,z];//обявляем результирующую матрицу c a из первой матрицы и z из второй. почему? не знаю((

FillArrayRandomNumbers(firstMatrix);//используем объявленную  первой матрицы
PrintArray(firstMatrix); //выводим на экран первую матрицу
System.Console.WriteLine();
FillArrayRandomNumbers(secondMatrix);//используем объявленную функцию второй матрицы
PrintArray(secondMatrix);// выводим на экран вторую матрицу
MultiplyMatrix(firstMatrix, secondMatrix, matrixResalt);//используем объявленную функцию результирующей матрицы
System.Console.WriteLine();
System.Console.WriteLine("результат умножения матриц: ");
PrintArray(matrixResalt);// выводим на экран результирующую матрицу

void FillArrayRandomNumbers(double[,] array)//объявляем функцию.заполняем массив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void PrintArray(double[,] array)//выводим в терминал массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
//Произведение матрицы A размера m × n и матрицы B размера n × k — это матрица C размера m × k,
//в которой элемент c_{ij} ​равен сумме произведений элементов i строки матрицы A
//на соответствующие элементы j столбца матрицы B : 
//c_{ij}=a_{i1} * b_{1j} + a_{i2} * b_{2j}+...+a_{in}b_{nj}

void MultiplyMatrix(double[,] firstMatrix, double[,] secondMatrix, double[,] matrixResalt )
{
  for (int i = 0; i < matrixResalt.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResalt.GetLength(1); j++)
    {
      double sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix [i,k] * secondMatrix [k,j];
      }
      matrixResalt[i,j] = sum;
    }
  }
}