Console.WriteLine("Write your name");
string username = Console.ReadLine() ?? "";

if (username.ToLower() ==  "маша")
{
    Console.WriteLine("Hurray, it's Маша");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}