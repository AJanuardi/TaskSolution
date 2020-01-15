  
using System;

namespace SumArgument
{
    public class Program10
    {
        static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
            int[] arr = {1,2,3,4,5};
            Console.Write(jumlah(arr));
        }

        public static int jumlah(int[] num) 
        {
            int hasil = 0;
            foreach(int i in num){
                hasil += i;
            }
            return hasil;
        }
    }
}