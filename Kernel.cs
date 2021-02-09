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
            Console.WriteLine("< program > Copyright(C) < year >  < name of author >");
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
