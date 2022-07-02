bool PalyndromCheck(string PalyNumber)
{
    if (PalyNumber.StartsWith("-")) PalyNumber = PalyNumber.Substring(1);
    bool palyCheck = true;
    for (int count = 0; count < Convert.ToInt32(PalyNumber.Length / 2); count++)
    {
        if (PalyNumber[count] != PalyNumber[PalyNumber.Length - 1 - count])
        {
            palyCheck = false;
            break;
        }
    }
    return palyCheck;
}
Console.Clear();
Console.Write("Введите целое число ");
string Number = Console.ReadLine();
if (PalyndromCheck(Number)) Console.WriteLine("Введенное число палиндром");
else Console.WriteLine("Введенное число не палиндром");