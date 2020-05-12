using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int temp;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요 : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i <array.Length; i++)
            {
                for(int j = i+1; j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("가장 큰 수 : " + array[4]);
            Console.WriteLine("가장 작은 수 : " + array[0]);
        }
    }
}
