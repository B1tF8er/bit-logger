namespace Bit.Logger.Models
{
    using System.Text;

    public class Log
    {
        public string Id { get; set; }

        public string Level { get; set; }

        public string Message { get; set; }

        public string Date { get; set; }

        public string Class { get; set; }

        public string Method { get; set; }

        public string Exception { get; set; }

        public override string ToString() =>
            new StringBuilder()
                .Append("Level: ").Append(Level).Append(' ')
                .Append("Message: ").Append(Message).Append(' ')
                .Append("Date: ").Append(Date).Append(' ')
                .Append("Class: ").Append(Class).Append(' ')
                .Append("Method: ").Append(Method).Append(' ')
                .Append("Exception: ").Append(Exception)
                .ToString();
    }
}
