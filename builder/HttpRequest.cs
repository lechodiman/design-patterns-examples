using System.Collections.Generic;

namespace builder
{
    public class HttpRequest
    {
        private Dictionary<string, string> _headers;
        private string _body;
        private string _method;
        private string _protocol;
        private string _host;
        private string _protocolVersion;

        // No one can directly instantiate this class
        private HttpRequest()
        {

        }

        public class Builder
        {
            private HttpRequest _httpRequest;

            // This builder needs the minimum necessary attributes to build
            public Builder(string host)
            {
                _httpRequest = new HttpRequest();

                // We can add default parameters
                _httpRequest._host = host;
                _httpRequest._method = "GET";
                _httpRequest._protocol = "http";
                _httpRequest._protocolVersion = "1.1";

            }

            public Builder SetBody(string body)
            {
                _httpRequest._body = body;
                return this;
            }

            public Builder SetMethod(string method)
            {
                _httpRequest._method = method;
                return this;
            }

            public Builder SetProtocol(string protocol)
            {
                _httpRequest._protocol = protocol;
                return this;
            }

            public Builder AddHeader(string key, string value)
            {
                _httpRequest._headers.Add(key, value);
                return this;
            }

            public HttpRequest Build()
            {
                return _httpRequest;
            }

        }
    }
}
