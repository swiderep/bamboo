using System;
using System.Globalization;

namespace ServiceClient
{
    public interface IService : IDisposable
    {
        string Name { get; }
        IDisposable Connect();
        string GetContent(long identity);
        string GetTimeStamp(DateTimeFormatInfo dateTimeFormat);
        string GetTimeStamp(DateTimeFormatInfo dateTimeFormatInfo, string fake);
    }
}