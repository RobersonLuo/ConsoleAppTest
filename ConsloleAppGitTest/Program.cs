using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsloleAppGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the word of GitHub...\n");

            Helper help = new Helper();
            string name = help.ShowName();
            Console.Write("Hello " + name);

            Console.ReadKey();
        }
    }
}
