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

        public override void Run(CosmosVFS vfs, filesystem.Dir dir, string[] input)
        {
            try
            {
                var fDir = input[1];
                var d = vfs.GetDirectory(fDir);
            }
            catch (Exception e)
            {
                Console.WriteLine("cant find directory: " + e.Message);
            }
            finally
            {
                dir.dir = dir + "/" + input[1];
            }
        }
    }
}
