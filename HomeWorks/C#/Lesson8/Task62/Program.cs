Console.Clear();
Console.Write("Введите количество строк ");
int matrixLength = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int matrixHigh = Int32.Parse(Console.ReadLine());;
int maxNumber = matrixLength * matrixHigh;
int[,] matrix = new int[matrixLength, matrixHigh];
int rowNumber = 0;
int columnNumber = 0;
bool incrimentRowColumn = true;
for(int elementNumber = 1; elementNumber <= maxNumber; elementNumber++)
{
    matrix[rowNumber, columnNumber] = elementNumber;
    if (incrimentRowColumn)
    {
        if(columnNumber != matrix.GetLength(1) - 1 && matrix[rowNumber, columnNumber + 1] == 0) columnNumber++;
        else
        {
            if(rowNumber != matrix.GetLength(0) - 1 && matrix[rowNumber + 1, columnNumber] == 0) rowNumber++;
            else 
            {
                incrimentRowColumn = false;
                columnNumber--;
            }
        }
    }
    else
    {
        if(columnNumber != 0 && matrix[rowNumber, columnNumber - 1] == 0) columnNumber--;
        else
        {
            if(rowNumber != 0 && matrix[rowNumber - 1, columnNumber] == 0) rowNumber--;
            else
            {
                incrimentRowColumn = true;
                columnNumber++;
            }
        }
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}