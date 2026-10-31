using System;
using System.Collections.Generic;//allows u use lists
class Program
{
    static void Main(string[] args)
    {
       List<int> numbers= new List<int>();
       int userNumber=-2; 

       while(userNumber!=0)
        {
            Console.Write("Enter number to add to list Or 0 to End! ");
            string response=Console.ReadLine();
            userNumber=int.Parse(response);

            if(userNumber!=0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum=0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
            Console.WriteLine($"The sum of the numbers you have selected is {sum}");
            
        int countNumbers=numbers.Count;
        float average=(float)sum/countNumbers;
        Console.WriteLine($"The average of the numbers you have selected is {average}");

        int max=numbers[0];
        int pmax=100000000;
        foreach(int number in numbers)
        {
            if(number>max)
            {
                max=number;
            }
            if(number > 0 && number < pmax)
            {  
                pmax=number;
            }
        }
        Console.WriteLine($"The largest number you entered is {max}");
        Console.WriteLine($"The largest Positive number you entered is {pmax}");
    }
}