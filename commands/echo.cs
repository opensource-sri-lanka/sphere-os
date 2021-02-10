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
                var echo = ci.input[1];
                Console.WriteLine(echo.Remove(0, 5));
            }
            catch (Exception e)
            {
                Console.WriteLine("Command not found " + e.Message);
            }
        }
    }
}