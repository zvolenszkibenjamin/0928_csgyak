using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0928_csgyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string txt = "GitHub próba de nem tudom minek,";
            string txt2 = "főleg hogy én már használom de mindegy";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (txt.Length / 2), (Console.WindowHeight / 2) - 1);
            Console.Write(txt);
            Console.SetCursorPosition((Console.WindowWidth / 2) - (txt2.Length / 2), Console.WindowHeight / 2);
            Console.Write(txt2);
            Console.ReadKey(true);
        }
    }
}
