using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
       int i,j=0;
       string[] stringArray = new string[20];

       Console.Write("Enter a number: ");
       int num = Int32.Parse(Console.ReadLine());

    for(i=1;i<=num;i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
            stringArray[j] = "fizzbuzz";
        else if (i % 5 == 0)
            stringArray[j] = "buzz";
        else if (i % 3 == 0)
            stringArray[j] = "fizz";
        else
            stringArray[j] = i.ToString();
        j++;
    }
    foreach (var item in stringArray)
    {
        Console.WriteLine(item);
    }
    Console.ReadLine();
   
        }
    }
}
