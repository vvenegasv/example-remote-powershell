using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExampleRemotePowersshell.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Server called!");
        }
    }
}
