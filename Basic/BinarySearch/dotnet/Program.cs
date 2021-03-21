
using System.Collections;
using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");

             int[] arr=new int[] {1,5,8,12,24,25,38,45,56,98};
             var arrLength=10;
             var searchNumber=38;
             Console.WriteLine($"Idndex for {searchNumber} is {BinarySearch(arr,arrLength,searchNumber)}");
            
             arrLength=6;
             var searchName="Gizem";
             string[] arrName=new string[] {"Feyyaz","Gizem","Kamil","Murat", "Osman","Yusuf"};
             Console.WriteLine($"Idndex for {searchName} is {BinarySearch(arrName,arrLength,searchName)}");

        }

        static int BinarySearch<T>(T[] arr,int n, T value ) where T : IComparable
        {

            int left=0, right=n-1;

            while(left<=right){
                
                var mid=(left+right)/2;
                var resultIndex=value.CompareTo(arr[mid]);
             
                if(resultIndex==0) return mid;

                if(resultIndex>0)
                 left=mid+1;
                 else
                right=mid-1;
            
            }
           
            return -1;
        }
    }


}
