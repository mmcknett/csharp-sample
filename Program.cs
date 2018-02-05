using System;

namespace sample
{
    class SampleProgram
    {
        static void Main(string[] args)
        {
            Writer.Write();

            // Pretend we got these things in as args...
            args = new string[]{ "First Thing", "Second Thing" };

            var arg0Writer = new InstanceWriter(args[0]);
            var arg1Writer = new InstanceWriter(args[1]);

            arg0Writer.Write();
            arg1Writer.Write();
        }
    }

    class Writer
    {
        public static void Write()
        {
            Console.WriteLine(WhatToSay());
        }

        private static string WhatToSay()
        {
            return "Hello Amy!";
        }
    }

    class InstanceWriter
    {
        private string _thingToWrite;

        public InstanceWriter(string thingToWrite)
        {
            this._thingToWrite = thingToWrite;
        }

        public void Write()
        {
            Console.WriteLine(_thingToWrite);
        }
    }
}
