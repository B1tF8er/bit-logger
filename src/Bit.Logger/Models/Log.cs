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
                .Append($"Level: {Level} ")
                .Append($"Message: {Message} ")
                .Append($"Date: {Date} ")
                .Append($"Class: {Class} ")
                .Append($"Method: {Method} ")
                .Append($"Exception: {Exception}")
                .ToString();
    }
}
