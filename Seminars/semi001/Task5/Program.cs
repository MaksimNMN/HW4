


Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("Одно число является квадратом другог");
}
else
{
    Console.WriteLine("Не является");
}