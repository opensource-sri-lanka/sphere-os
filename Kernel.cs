using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace sphere_os
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("sphere-os Copyright(C) 2021  Tarith, Dinuda");
            Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY;  This is free software, and you are welcome to redistribute it");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
