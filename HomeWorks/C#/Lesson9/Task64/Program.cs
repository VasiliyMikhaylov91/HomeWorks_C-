int EnterSiting(string sitingName)
{
    Console.Write("Введите " + sitingName + " ");
    int siting = Convert.ToInt32(Console.ReadLine());
    return siting;
}
string BetveenNumber(int minNumber, int maxNumber)
{
    if (maxNumber == minNumber) return minNumber.ToString();
    else return minNumber + ", " + BetveenNumber(minNumber + 1, maxNumber);
}

int firstNumber = EnterSiting("Первое число");
int secondNumber = EnterSiting("Второе число");
if(firstNumber > secondNumber)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}
Console.WriteLine(BetveenNumber(firstNumber, secondNumber));