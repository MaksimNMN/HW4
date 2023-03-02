// Напишите программу которая принимает  на вход число (N)
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
