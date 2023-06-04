using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Refresh1
{
    internal static class UsefulMaths
    {
        //Making a class static prevents an instance of it to be made.
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name + "!!");
        }
        //Static functions dont require an instance of the class to be used.
    }
}
