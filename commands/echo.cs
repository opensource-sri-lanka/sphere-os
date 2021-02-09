using Cosmos.System.FileSystem;
using sphere_os.filesystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class Echo : command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CosmosVFS vfs, Dir dir, string[] input)
        {
            // input = Console.ReadLine()
            // if (input.StartsWith("echo ")) { Console.WriteLine(input.Remove(0, 5)); }
           // Console.WriteLine(Console.ReadLine());
           /* var read = Console.ReadLine();
            if (read == "echo ")
            {
                // if (read.StartsWith("echo ")) { Console.WriteLine(read.Remove(0, 5)); }
                Console.WriteLine(input);
                Console.WriteLine(read);
            }
           */
        }
    }
}