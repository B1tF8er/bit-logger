namespace Bit.Logger.Models
{
    using System;

    public class Log
    {
        public string Id { get; set; }
        
        public string Level { get; set; }
        
        public string Message { get; set; }

        public string Date { get; set; }

        public string Class { get; set; }
        
        public string Method { get; set; }

        public string Exception { get; set; }
    }
}