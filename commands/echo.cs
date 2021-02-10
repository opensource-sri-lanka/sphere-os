using Cosmos.System.FileSystem;
using sphere_os.filesystem;
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

        public override void Run(CommandInput ci)
        {
            try
            {
                for (var i = 1; i < ci.input.Length; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(ci.input[i]);
                    } else
                    {
                        Console.Write(" "+ci.input[i]);
                    }
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Command not found " + e.Message);
            }
        }
    }
}