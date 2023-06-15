Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);
if (num >= 6 && num <= 7);
    {
        Console.WriteLine($" {num} -> да, это выходной день");
    }
if (num >= 1 && num <= 5)
    {
        Console.WriteLine($" {num} -> нет, это будний день");
    }