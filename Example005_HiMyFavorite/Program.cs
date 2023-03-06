Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if (username.ToLower() == "вася")
{
  Console.WriteLine("Привет Васюся");
}
else
{
  Console.Write("Привет");
  Console.Write(username);
}