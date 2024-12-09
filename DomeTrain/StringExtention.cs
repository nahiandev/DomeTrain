using System.Text;

namespace DomeTrain
{
    public static class StringExtention
    {
        public static string GetUTF8Bytes(this string text)
        {
            var bytes = Encoding.UTF8.GetBytes(text);

            return string.Join("", bytes);
        }
    }
}
