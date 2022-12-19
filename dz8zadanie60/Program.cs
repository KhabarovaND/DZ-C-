int[,,] array3D = new int[2, 2, 2];//создаем трехмерный массив (по условиям задачи размером 2х2х2)
FillArray(array3D);
PrintIndex(array3D);


// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива рандомными числами
void FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                
                arr[i, j, k] = Convert.ToInt32(new Random().Next(10, 100));
                

            }
        }
    }
}

