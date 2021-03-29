using System.Data;
using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
             var numbers=new int[] {7,3,5,8,2,9,4,15,6};
            Console.WriteLine("Insertion sort");
            numbers=Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
              
               Console.WriteLine( numbers[i]);
            }
           
        }

        static int[] Sort(int[] array) {
            int length=array.Length;
            for (int i = 1; i < length; i++)
            {
                int addedNumber=array[i];
                for (int k = i-1;  k>=0 && addedNumber<array[k];  k--)
                {
                   if(addedNumber<array[k]){
                       array[k+1]=array[k];
                       array[k]=addedNumber;
                   }
                }
            }

            return array;

        }
    }
}
