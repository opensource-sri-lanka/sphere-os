using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class CD: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                var fDir = ci.input[1];
                var d = ci.vfs.GetDirectory(fDir);
            }
            catch (Exception e)
            {
                Console.WriteLine("cant find directory: " + e.Message);
            }
            finally
            {
                ci.dir.dir = ci.dir.dir + "/" + ci.input[1];
            }
        }
    }
}
