using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tb = new TextBox();
            TextBox tb2 = new TextBox();

            tb.Text = "chicken";
            tb.BackColor = ConsoleColor.Blue;
            tb.ForeColor = ConsoleColor.Cyan;
            tb.Padding = 4;

            tb2.Text = "tea";
            tb2.BackColor = ConsoleColor.Green;
            tb2.ForeColor = ConsoleColor.Red;
            tb2.Padding = 10;

        
            tb.DisplayText();
            tb2.DisplayText();

            Console.ReadKey();
            

        }







    }
}
