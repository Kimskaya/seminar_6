//task 43: Program, which finds the point of intersection of  2 lines,
// expressed by equations  y = k1 * x + b1, y = k2 * x + b2; 
//  b1, k1, b2 and  k2 are specified by a user 
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetUserData(string message)
{
    Console.WriteLine(message);
    int Message = int.Parse(Console.ReadLine()!);
    return Message;
}
double b1 = GetUserData(" Input b1 ");
double k1 = GetUserData(" Input k1 ");
double b2 = GetUserData(" Input b2 ");
double k2 = GetUserData(" Input k2 ");
double x = 0;
double y = 0;
x = (b2 - b1)/( k1-k2);
y = k1 * (b2-b1)/(k1-k2)+b1;
Console.WriteLine($"The poit of intersection has coordiantes is {x} for X and {y} for Y");
 