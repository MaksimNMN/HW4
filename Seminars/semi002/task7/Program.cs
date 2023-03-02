// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21                     //Метод для упрощеного решения

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double xa = ReadNumber("Ведите координату точка А по Х");
double ya = ReadNumber("Ведите координату точка А по Y");
double xb = ReadNumber("Ведите координату точка B по Х");
double yb = ReadNumber("Ведите координату точка B по Y");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.WriteLine($"{res:f2}");
