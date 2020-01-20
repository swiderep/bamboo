using System;
using System.Globalization;
using System.Text;

namespace ServiceClient
{
    public class Client : IDisposable
    {
        readonly IContentFormat format;
        readonly IService service;

        static readonly int Identity = 2;

        public Client(IService service)
        {
            this.service = service;
        }

        public Client(IService service, IContentFormat format) : this(service)
        {
            this.format = format;
        }

        public string GetServiceName()
        {
            var name = service.Name;
            service.Dispose();
            return name;
        }

        public string GetContent(long identity)
        {
            service.Connect();
            var result = service.GetContent(identity);
            service.Dispose();

            return result;
        }

        public string GetContentFormatted(long identity)
        {
            var content = GetContent(identity);
            return format.Format(content);
        }

        public string GetClientContentFormatted()
        {
            var content = new StringBuilder();
            content.Append("This is a client ");
            content.Append(Identity);
            content.Append("!");
            return format.Format(content);
        }

        public string GetStartupTime(DateTimeFormatInfo dateTimeFormatInfo)
        {
            return service.GetTimeStamp(dateTimeFormatInfo);
        }

        public void Dispose()
        {
            service.Dispose();
        }
    }
}
