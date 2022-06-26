Console.Write("Введите трехзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
int Digit = (Number / 10) % 10;

Console.WriteLine("Вторая цифра числа " + Digit);