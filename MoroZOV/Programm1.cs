using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoroZOV
{
    static class Programm1
    {
        public static void main()
        {
            int[] arr=new int[3].Select(i=>new Random().Next(100)).ToArray();
            int[] arr1=arr.OrderBy(x=>x).ToArray().Print();
            int[] arr2=arr.OrderByDescending(x=>x).ToArray();
            if (arr.SequenceEqual(arr1))

                "ordarby".Print();

            else if (arr.SequenceEqual(arr2))
                "OrderByDescending".Print();
            else
                "random".Print();




        }
    }
}
