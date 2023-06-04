using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Refresh1
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef makes Pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Chicken Parm");
        }
    }
}
