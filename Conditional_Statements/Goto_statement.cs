/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    public class Goto_statement
    {
        public static void Main(String[] args) {

        ineligible:
            Console.WriteLine("Yor are not eligible to vote");
            int age = 16;

            if (age < 18)
            {
                goto ineligible;
            }
            else if (age >= 18) {
                Console.WriteLine("you can vote");
            }

        }
    }
}
*/