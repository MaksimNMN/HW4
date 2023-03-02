// Напишите программу которая будет принимать на вход два числа и выводить 
// является ли второе число кратным первому 
// 34, 5  -> не краттно, остаток 4
// 16, 4 -> кртано


Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

int res = num1 / num2;

if (res != 0) 
{
    Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Второе число кратно первому");
}


// Console.WriteLine(number);
// int lastDigit = number % 10;
// int firstDigit = number / 100;
// int res  = firstDigit *10 + lastDigit; 
// // if (firstDigit > lastDigit)
// // {
// //     Console.WriteLine($"max {firstDigit}, min {lastDigit}");
// // }
// // else
// // {
// //     Console.WriteLine($"max {lastDigit}, min {firstDigit}");
// // }

 Console.WriteLine(res);