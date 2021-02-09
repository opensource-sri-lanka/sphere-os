// main file
/* Copyright (C) 2021 Dinuda Yaggahavita, Tarith Jayasooriya

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
*/

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
            Console.WriteLine("Sphere OS Copyright(C) 2021  Dinuda Yaggahavita, Tarith Jayasooriya");
            Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY;  This is free software, and you are welcome to redistribute it");
        }

        protected override void Run()
        {
            Console.Write("$: ");
            var input = Console.ReadLine();
            switch (input)
            {
                // commands here
                default:
                    Console.Write("command not found");
                    break;
            }
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}