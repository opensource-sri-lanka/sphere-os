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

                if (ci.input[1] == "..")
                {
                    var lastDir = filesystem.Utils.GoBackADir(ci.dir.dir);
                    ci.dir.dir = lastDir;
                } 
                else if (ci.input[1] == "/")
                {
                    ci.dir.dir = "/";
                }
                else
                {
                    var d = System.IO.Directory.Exists(ci.dir.dir + "/" + fDir);
                    if (d) {
                        if (ci.dir.dir == "/")
                        {
                            ci.dir.dir += ci.input[1];
                        }
                        else
                        {
                            ci.dir.dir = ci.dir.dir + "/" + ci.input[1];
                        }
                    } else
                    {
                        Console.WriteLine("cant find directory");
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("cant find directory: " + e.Message);
            }
        }
    }
}
