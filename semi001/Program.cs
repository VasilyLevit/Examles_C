// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите число от 1 до 7");
int n = int.Parse(Console.ReadLine());

if (n==1)
{
    Console.WriteLine("День недели: Понедельник");
}
if (n==2)
{
    Console.WriteLine("День недели: Вторник");
}if (n==3)
{
    Console.WriteLine("День недели: Среда");
}if (n==4)
{
    Console.WriteLine("День недели: Четверг");
}
if (n==5)
{
    Console.WriteLine("День недели: Пятница");
}
if (n==6)
{
    Console.WriteLine("День недели: Суббота");
}
if (n==7)
{
    Console.WriteLine("День недели: Воскресенье");
} else 
Console.WriteLine("Ошибка ввода");
