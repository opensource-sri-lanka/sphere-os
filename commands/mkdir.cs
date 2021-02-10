using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class Mkdir: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                ci.vfs.CreateDirectory(ci.dir.dir+"/"+ci.input[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("cant create directory: " + e.Message);
            }
        }
    }
}
