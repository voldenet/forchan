using System;
using System.IO;

namespace forchan.Fetch
{
    class WebRequester
    {
        public IThrottler Throttle = null;
        public Action<System.Net.WebRequest> Modifier = (r) =>
        {
            r.Proxy = null;
        };

        public String GetString(String url)
        {
            if (Throttle != null)
            {
                Throttle.Wait();
            }
            var request = System.Net.WebRequest.Create(url);
            if (Modifier != null)
            {
                Modifier(request);
            }

            using (var response = request.GetResponse())
            using (StreamReader responseStream = new StreamReader(response.GetResponseStream()))
            {
                return responseStream.ReadToEnd();
            }
        }
    }
}
