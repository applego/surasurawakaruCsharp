using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NoModori
{

    static void Main()
    {

        void WriteArray(int[,] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - 1; ++j)
                {

                    Console.Write("{0}, ", array[i,j]); //インデックスが境界外　例外
                }
                Console.Write(array[array.Length - 1,array.Length -1] + "}\n");
            }

        }

        int[,] myarray = new int[,]
        {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 8,9,10,11,12,13,14},
    };


        WriteArray(myarray);
    }
}