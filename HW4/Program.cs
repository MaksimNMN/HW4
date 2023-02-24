// // ЗАДАЧА 1 Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве. ДОМАШКА

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double xa = ReadNumber("Ведите координату точка А по Х");
double ya = ReadNumber("Ведите координату точка А по Y");
double za = ReadNumber("Введите координату точка A по Z");
double xb = ReadNumber("Ведите координату точка B по Х");
double yb = ReadNumber("Ведите координату точка B по Y");
double zy = ReadNumber("Введите координату точка Y по Z");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zy, 2) * 1.0);
Console.WriteLine($"{res:f2}");



//  ЗАДАЧА 2 Напишите программу которая принимает на вход  пятизначное число  и проверяет, 
// является ли оно палиндромом ДОМАШКА ..

// 14212 - нет
// 12821 - да
// 23432 - да

// Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// int length = number.Length;

// if (length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }







// ЗАДАЧА 3 Напишите программу которая принимает  на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27  ДОМАШКА 

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;


for (index = 0; index <= N; index++)
{
    double c = Math.Pow(index, 3);
    
    Console.WriteLine(c);
}
