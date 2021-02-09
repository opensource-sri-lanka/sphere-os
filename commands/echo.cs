using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class echo : command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void run(CosmosVFS vfs, filesystem.Dir dir, string[] input)
        {
            Console.Write("> ");
            // NOTE: use input variable
            var input = Console.ReadLine();
            if (input == "echo ")
            {
                if (input.StartsWith("echo ")) { Console.WriteLine(input.Remove(0, 5)); }
            }
        }
    }
}
