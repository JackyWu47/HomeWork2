using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //99乘法表for迴圈排列
            {

                
                int j, k,sum;
                for (j = 1; j < 10; j++)
                {
                    for (k = 1; k < 10; k++)
                    {
                        sum = j * k;
                        Console.Write(k + "*" + j + "=" + sum + "\t");
                    }
                    Console.WriteLine("\n");
                }
                
            }
            //99乘法表while迴圈
            {
                
                int i = 1, j = 1, sum=0;
                while (i < 10)
                {
                    while (j < 10)
                    {
                        sum = i * j;
                        Console.Write(i + "*" + j + "=");
                        if(sum<10)
                        { 
                          Console.Write(" "+sum + "\t");
                        }
                        else
                        {
                            Console.Write(+sum + "\t");
                        }
                        j++;
                    }
                    i++;
                    Console.WriteLine("\n");
                    j = 1;
                }
                
            }
        }
    }
}
