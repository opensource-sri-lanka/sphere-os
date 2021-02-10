using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class Mkfile: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            try
            {
                ci.vfs.CreateFile(ci.dir.dir+"/"+ci.input[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("cant create new file: " + e.Message);
            }
        }
    }
}
