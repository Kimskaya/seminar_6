//Задача 41: User inputs M numbers from the keyboard. Count how many numbers >0 he entered.

//0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int GetQuantityOfNumbers(string message)
{
    Console.WriteLine(message);
    int NumberM = int.Parse(Console.ReadLine()!); 
    return NumberM;
}
int Length= GetQuantityOfNumbers("Input the quantity of numbers you want to enter");


int [] GetUserArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         Console.WriteLine($"Input the element number {i+1}  ");
         array [i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
int [] Array = GetUserArray (5); 

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);

int CountPositivNumbers(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
      {
        if (Array[i] > 0)
          {
            count = count + 1;
          }
       }
    return count;
}
int count = CountPositivNumbers(Array);
Console.WriteLine();
Console.WriteLine($"The quantity of positive numbers is {count}");
