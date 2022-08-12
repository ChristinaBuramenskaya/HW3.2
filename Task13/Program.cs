Console.WriteLine("Введите число");
string number = Console.ReadLine();
int length = number.Length;
if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(number[2]);
}


