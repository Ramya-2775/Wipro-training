using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq.projects
{
    internal class funcdel
    {
        class function
        {
            static int sum(int a, int b)
            {
                return a + b;
            }

            static void Main(string[] args)
            {
                Func<int, int, int> add = sum;

                int result = add(6, 7);

                Console.WriteLine(result);

            }
        }
    }
}
