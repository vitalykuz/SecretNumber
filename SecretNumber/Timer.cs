using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SecretNumber
{
    public class Timer
    {
        public Stopwatch Watch = new Stopwatch();

        public void StartWatch()
        {
            Watch = Stopwatch.StartNew();          
        }

        public void StopWatch()
        {
            Watch.Stop();
        }

        public long GetElapsedTimeInMs()
        {
            var elapsedMs = Watch.ElapsedMilliseconds;
            return elapsedMs;
        }
    }
}