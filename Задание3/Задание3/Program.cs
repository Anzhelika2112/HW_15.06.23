Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

bool IsWeekend(int weekday)
{
    if(number > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

if(ValidateWeekday(number))
{
    if(IsWeekend(number))
    {
    Console.WriteLine("Это выходной день");
    }
else
{
    Console.WriteLine("Это будний день");
}
}