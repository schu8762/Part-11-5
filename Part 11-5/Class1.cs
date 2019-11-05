using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_11_5
{
    class TextBox
    {
        public int Padding {get; set;}

        public string Text { get; set; }
            
        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public TextBox()
        {
            Padding = 0;
            Text = string.Empty;
            BackColor = ConsoleColor.Black;
            ForeColor = ConsoleColor.White;
        }

        public void DisplayText()
        {
            Console.BackgroundColor = BackColor;
            Console.ForegroundColor = ForeColor;
            string sentence = $"{Text.PadLeft(Padding).PadRight(Padding)}";
            Console.WriteLine(sentence);
                      
        }
        




    }
}
