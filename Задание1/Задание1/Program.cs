Console.Clear();
Console.Write("Введите целое трёхзначное число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);
int a1 = num % 100;
int a3 = num % 10;
int res = (a1 - a3)/10;
Console.WriteLine($" {num} -> {res}");