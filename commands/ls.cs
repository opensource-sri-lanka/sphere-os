using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class Ls : command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                var input = ci.input[0];
                var cDir = ci.dir;
                var l = ci.vfs.GetDirectory("/");
                Console.WriteLine(l);
            }
            catch (Exception e)
            {
                Console.WriteLine("Command not found: : " + e.Message);
            }
        }
    }
}
    