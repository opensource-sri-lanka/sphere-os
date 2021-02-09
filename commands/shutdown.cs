using Cosmos.System.FileSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.commands
{
    class Shutdown: command
    {
        public override void getInfo()
        {
            throw new NotImplementedException();
        }

        public override void Run(CommandInput ci)
        {
            Cosmos.System.Power.Shutdown();
        }
    }
}
