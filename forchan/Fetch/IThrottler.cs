using System;

namespace forchan.Fetch
{
    interface IThrottler
    {
        void Reset();
        void Wait();
    }
}
