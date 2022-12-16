Console.WriteLine("Введите количество строк  ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lines, columns];//обявляем двумерный массив "numbers" с коллич.строк lines и с коллич.столбцов colums
FillArrayRandomNumbers(numbers);//используем объявленную функцию
PrintArray(numbers);
System.Console.WriteLine();
FillNumber(numbers);


void FillArrayRandomNumbers(double[,] array)//объявляем функцию.заполняем массив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(1, 10));
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

void FillNumber(double[,] array)
  { for ( int i = 0; i < array.GetLength( 0 ); i++ )
            for ( int j = 0; j < array.GetLength( 1 ); j++ )
                if ( array[ i, j ] == x )
               Console.Write($"координаты искомого числа: {i},{j}  ");
    }
                        System.Console.WriteLine(); 
   