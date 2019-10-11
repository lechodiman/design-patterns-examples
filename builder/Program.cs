using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this case, HttpRequest needs too many arguments
            // var httpRequest = new HttpRequest(a lot of attributes)

            // Now it looks prettier
            // Now we only call methods on the Builder, so it is not a train wreck
            var httpRequest = new HttpRequest
                .Builder(host: "www.google.com")
                .AddHeader("Content-Type", "application/json")
                .SetMethod("GET")
                .SetProtocol("https")
                .Build();
        }
    }
}
