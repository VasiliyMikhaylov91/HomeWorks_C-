int[] CreateArray (int ArraySize)
{
    int [] newArray = new int[ArraySize];
    for (int arrayCount = 0; arrayCount < ArraySize; arrayCount++)
    {
        Console.Write($"Введите координату точки {arrayCount + 1} ");
        newArray[arrayCount] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
double VectorSize (int[] arrayFirst, int[] arraySecond)
{
    double resultSize = 0;
    int digree = 2;
    double elementDoubleSumm = 0;
    for (int elementNumber = 0; elementNumber < arrayFirst.Length; elementNumber++)
    {
        elementDoubleSumm = elementDoubleSumm + Math.Pow((arrayFirst[elementNumber] - arraySecond[elementNumber]), digree);
    }
        resultSize = Math.Sqrt(elementDoubleSumm);
    return resultSize;
}
Console.Clear();
Console.Write("Введите количество измерений от 1 до 3 ");
int dementions = Convert.ToInt32(Console.ReadLine());
if ((dementions >= 1) && (dementions <= 3))
{
    Console.WriteLine("Введите координаты точки А");
    int[] arrayA = CreateArray(dementions);
    Console.WriteLine("Введите координаты точки В");
    int[] arrayB = CreateArray(dementions);
    Console.WriteLine("Расстояние между точками А и В " + (VectorSize(arrayA, arrayB)));
}
else Console.WriteLine("Ошибка количества измерений");