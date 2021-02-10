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
            try
            {
                var read = input[1];
                if (read.StartsWith("echo ")) { Console.WriteLine(read.Remove(0, 5)); }
            }
            catch (Exception e)
            {
                Console.WriteLine("Command not found " + e.Message);
            }
        }
    }
}