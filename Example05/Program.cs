Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Лёха")
{
    Console.WriteLine("Здарова, Лёха!!!");
}
else
{
    Console.WriteLine("Ну привет...");
    Console.WriteLine(username);
}