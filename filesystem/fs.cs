using System;
using System.Collections.Generic;
using System.Text;

namespace sphere_os.filesystem
{
    public class Dir
    {
        public string dir = "/";
    }

    static class Utils
    {
        public static string[] PathToArray(string p)
        {
            return p.Split("/");
        }

        // returns the path before the current path
        // example
        // string d = "a/b/c/d"
        // string b = fsTrack.GoBackADir(d)
        // Console.WriteLine(d) $ a/b/c
        public static string GoBackADir(string dir)
        {

            string[] a = PathToArray(dir);
            Console.WriteLine(a.Length);
            var v = "";

            for (var i = 0; i < a.Length; i++)
            {
                var divider = "";
                if (i != 1)
                {
                    divider = "/";
                }
                v += divider + a[i];
            }
            return v;
        }
    }

}