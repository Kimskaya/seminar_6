////task 43: Program, which finds the point of intersection of  2 lines,
// expressed by equations  y = k1 * x + b1, y = k2 * x + b2; 
//  b1, k1, b2 and  k2 are specified by a user 
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetUserData(string message)
{
    Console.WriteLine(message);
    int Message = int.Parse(Console.ReadLine()!);
    return Message;
}
int b1 = GetUserData(" Input b1 ");
int k1 = GetUserData(" Input k1 ");
int b2 = GetUserData(" Input b2 ");
int k2 = GetUserData(" Input k2 ");

int GetX (int b1, int k1, int b2, int k2)
{
int x = 0;
x = (b2 - b1)/( k1-k2);
}
return x;
int X = GetX(b1,k1,b2,k2);
int GetY (int b1, int k1, int b2, int k2)
{
int y = 0;
y = k1 * (b2-b1)/(k1-k2)+b1;
}
return y;
int Y = GetY(b1,k1,b2,k2);

Console.WriteLine($"The poit of intersection has coordiantes is {X} for X and {Y} for Y");
 