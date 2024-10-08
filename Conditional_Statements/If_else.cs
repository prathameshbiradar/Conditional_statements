
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class if_else
    {
        static void Main(string[] args)
        {

            int age = 20;
            if (age > 18)
            {
                Console.WriteLine("You can Vote");
            }
            else if (age > 22)
            {
                Console.WriteLine("You can vote and also participate in election");
            }
            else
            {
                Console.WriteLine("you cannot vote");
            }
        }
    }

}

