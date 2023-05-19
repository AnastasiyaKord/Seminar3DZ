// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double xa = ReadNumber("Введите коррдинату точка А по Х");
double ya = ReadNumber("Введите коррдинату точка А по Y");
double za = ReadNumber("Введите коррдинату точка A по Z");
double xb = ReadNumber("Введите коррдинату точка B по Х");
double yb = ReadNumber("Введите коррдинату точка B по Y");
double zb = ReadNumber("Введите коррдинату точка B по Z");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"{res:f2}");






