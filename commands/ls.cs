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
                var l = ci.vfs.GetDirectory("/");
                var output = System.IO.Directory.GetDirectories(ci.dir.dir);
                foreach (var i in output)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Command not found: : " + e.Message);
            }
        }
    }
}
    