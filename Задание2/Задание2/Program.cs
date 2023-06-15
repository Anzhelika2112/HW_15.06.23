Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
            result = number % 10;
    }
    return result; 
}
Console.WriteLine($" {num} -> {result}");
 
if (result == -1)
Console.WriteLine("третьей цифры нет");
