// Напишите программу, которая принимает на вход  число и проверяет кратно ли оно одновремено 
// 7 и 23 


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("Не Кратно");
}