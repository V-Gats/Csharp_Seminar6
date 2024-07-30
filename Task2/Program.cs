// Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-” 

void Main()
{
System.Console.Write("Ведите строку: ");
string? str = Console.ReadLine();
System.Console.WriteLine("ИСходная строка: " + str);

string low = str!.ToLower();
System.Console.WriteLine("Изминеная строка: " + low);

}

Main();