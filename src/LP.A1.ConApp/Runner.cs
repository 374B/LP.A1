using System;

namespace LP.A1.ConApp
{
    public class Runner
    {
        public decimal Key { get; }
        public string Description { get; }
        public Action Run { get; }

        public Runner(decimal key, string description, Action run)
        {
            Key = key;
            Description = description;
            Run = run;
        }
    }
}
