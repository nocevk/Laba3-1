using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {


                //Task1
                {
                    if (args is null)
                    {
                        throw new ArgumentNullException(nameof(args));
                    }

                    Console.Write("Введіть двозначне число N: ");
                    int N = int.Parse(Console.ReadLine());

                    int i = 1; 
                    int sum = 0;

                    Console.WriteLine("Непарні числа від 1 до {0}:", N);

               
                    while (i <= N)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i); 
                            sum += i; 
                        }
                        i++; 
                    }

                    
                    Console.WriteLine("Сума непарних чисел: " + sum);
                }
            }
        }
    }
}    
