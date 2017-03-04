using System;

namespace Algorithm
{
    public class TestTime : System.Diagnostics.Stopwatch, IDisposable
    {
        public TestTime ()
        {
            Start();
        }
        public void Dispose()
        {
            Stop();
            Console.WriteLine("Elapsed：{0}",this.Elapsed);
        }
    }
}
