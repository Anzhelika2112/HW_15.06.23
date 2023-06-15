Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);
int a3 (int num)
{
while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
if(ValidateNumber(number))
{
    Console.WriteLine($"{a3(number)}");
}
