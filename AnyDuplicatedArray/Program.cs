using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDuplicatedArray
{
    class Program
    {
        static int Duplicate(int[] numbers)
        {
            int length = numbers.Length;
            for (int i = 0; i < length; ++i)
            {
                if (numbers[i] < 0 || numbers[i] > length - 1)
                    throw new ArgumentException("Invalid numbers.");
            }
            for (int i = 0; i < length; ++i)
            {
                while (numbers[i] != i)
                {
                    if (numbers[i] == numbers[numbers[i]])
                    {
                        return numbers[i];
                    }
                    // swap numbers[i] and numbers[numbers[i]]
                    int temp = numbers[i];
                    numbers[i] = numbers[temp];
                    numbers[temp] = temp;
                    
                }
            }
            throw new ArgumentException("No duplications.");
        }

        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 0, 3, 5, 2 };
            int duplicate = Duplicate(array);
            System.Console.WriteLine("The Duplicated array is: " + duplicate);

        }
    }
}
