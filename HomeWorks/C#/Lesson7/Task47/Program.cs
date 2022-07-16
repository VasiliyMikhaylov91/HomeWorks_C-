Console.Write("Введите количество строк в массиве ");
int rowsNumbers = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве ");
int columnsNumbers = Int32.Parse(Console.ReadLine());
double[,] array = new double[rowsNumbers, columnsNumbers];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {   
        int sign = new Random().Next(2);       
        if(sign == 0) array[i, j] = new Random().NextDouble() * 100;
        else array[i, j] = - new Random().NextDouble() * 100;
        Console.Write(Math.Round(array[i, j], 3) + "\t");
    }
    Console.WriteLine();
}
