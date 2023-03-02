// // Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// 1 -> “x > 0 && y > 0”
// 2 -> “x < 0 && y > 0”
// 3 -> “x < 0 && y < 0”
// 4 -> “x > 0 && y < 0”
// 5 -> “Неверно введен номер четверти”


Console.WriteLine("Ведите № четверти");
int n = Convert.ToInt32(Console.ReadLine());

if (n==1)
{
    Console.WriteLine("Координаты x > 0 y > 0");
}
else if (n==2)
{
    Console.WriteLine("Координаты x < 0 y > 0");
}
else if (n==3)
{
    Console.WriteLine("Координаты x < 0 y < 0");
}
else if (n==4)
{
    Console.WriteLine("Координаты x > 0 y < 0");
}
else
{
    Console.WriteLine("Попробуйте другое число");
}