using System;

namespace forchan.Fetch
{
    class TimedThrottler : IThrottler
    {
        object sync = new object();
        DateTime last = new DateTime();
        public TimedThrottler(int interval)
        {
            WaitInterval = interval;
            last = DateTime.UtcNow;
        }
        int WaitInterval = 0;
        public void Wait()
        {
            lock (sync)
            {
                var waitTime = WaitInterval - (DateTime.UtcNow - last).TotalMilliseconds;
                if (waitTime > 0)
                {
                    System.Threading.Thread.Sleep((int)waitTime);
                }
                last = DateTime.UtcNow;
            }
        }

        public void Reset()
        {
            lock (sync)
            {
                last = new DateTime();
            }
        }
    }
}
