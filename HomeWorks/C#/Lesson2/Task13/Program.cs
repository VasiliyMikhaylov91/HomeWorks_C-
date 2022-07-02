int LengthNumber(int NumberLength, int notationLength)
{
    int sizeLength = 0;
    while (NumberLength != 0)
    {
        NumberLength = NumberLength / notationLength;
        sizeLength++;
    }
    return sizeLength;
}


int notation = 10;

Console.Write("Введите целое число ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 0) Number = Number * (-1);

int Length = LengthNumber(Number, notation);

Console.Write("Введите номер цифры в числе слева направо от 1 до N ");
int DigitNumber = Convert.ToInt32(Console.ReadLine());

if ((DigitNumber > Length) || (DigitNumber <= 0)) 
{
    Console.WriteLine("Ошибка - цифра не найдена");
}
else 
{
    Console.WriteLine("Указанная цифра в числе " + (Math.Floor(Number / Math.Pow(notation, (Length - DigitNumber)))) % notation);
}