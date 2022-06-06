// Применеие оператора ветвления if else
Console.WriteLine("Введите имя пользователя: ");
string userName = Console.ReadLine();
if(userName.ToLower() == "маша")  // To.Lower() переводит вводимые символы в нижний регистр
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(userName);
}