Console.WriteLine("Введите количество строк  ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int [lines, columns];//обявляем двумерный массив "numbers" с коллич.строк lines и с коллич.столбцов colums
FillArrayRandomNumbers(numbers);//используем объявленную функцию
PrintArray(numbers);
System.Console.WriteLine();
SortToLower(numbers);
System.Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)//объявляем функцию.заполняем массив рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void PrintArray(int[,] array)//выводим в терминал массив
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


// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
           
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            { 
            
              if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}