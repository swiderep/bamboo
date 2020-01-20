using System.Text;

namespace ServiceClient
{
    public interface IContentFormat
    {
        string Format(string content);
        string Format(StringBuilder content);
    }
}