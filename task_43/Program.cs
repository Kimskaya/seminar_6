//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetUserData(string message)
{
    Console.WriteLine(message);
    int Message = int.Parse(Console.ReadLine()!);
    return Message;
}

double b1 = GetUserData(" Введите значение b1 ");
double k1 = GetUserData(" Введите значение k1 ");
double b2 = GetUserData(" Введите значение b2 ");
double k2 = GetUserData(" Введите значение k2 ");
double x = 0;
double y = 0;
x = (-b2 + b1)/(-k1 + k2);
y = k2 * x + b2;
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");

