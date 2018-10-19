using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NoModori
{

    static void Main()
    {
        
        void WriteArray(int[] array)
        {
            Console.Write("{");
            for(int i = 0; i < array.Length -1; ++i)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.Write(array[array.Length - 1] + "}\n");
        }
    } 
}