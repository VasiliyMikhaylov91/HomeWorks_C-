void ArrayOut(int[] OutArray)
{
    Console.Write("[");
    for (int iOut = 0; iOut < OutArray.Length; iOut++)
    {
        if (iOut == OutArray.Length - 1) Console.WriteLine($"{OutArray[iOut]}]");
        else Console.Write($"{OutArray[iOut]}, ");
    }
}
int[] ArrayIn()
{
    int ArraySize = new Random().Next(1, 9);
    int[] InArray = new int[ArraySize];
    for (int iIn = 0; iIn < ArraySize; iIn++)
    {
        InArray[iIn] = new Random().Next(0, 100);
    }
    return InArray;
}

ArrayOut(ArrayIn());