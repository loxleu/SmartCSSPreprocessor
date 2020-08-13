using System;
using System.IO;
using System.Collections;

namespace scp_core
{
    class Mainclass
    {
        /// <summary>
        /// Main entry point of the program
        /// </summary>
        public static void Main()
        {
            string path = Environment.GetEnvironmentVariable("PATH") + Environment.CurrentDirectory;
            string[] args = Environment.GetCommandLineArgs();
            Environment.SetEnvironmentVariable("PATH", path);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
