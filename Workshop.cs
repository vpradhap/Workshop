using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop
{
    public class Workshop
    {
        public  static void PowerOf2()
        {
            Console.Write("Enter value for N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            if(N >= 0 && N < 31)
            {
                for(int i= 0; i <= N; i++)
                {
                    Console.WriteLine("2 Power "+i +" = "+Math.Pow(2,i));
                }
            }
            else
            {
                Console.WriteLine("2^31 overflows an int ");
            }
        }
    }
}
