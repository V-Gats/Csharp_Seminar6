// Задайте произвольную строку. Выясните, 
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

void Main()
{
System.Console.Write("Ведите строку: ");
string? str = Console.ReadLine();

str = str!.Replace(" ","").ToLower();

System.Console.Write(str);

var temp = new string(str.Reverse().ToArray());
System.Console.WriteLine(temp == str ? " -- это палиндром" : " -- Это не палиндром");
}

Main();