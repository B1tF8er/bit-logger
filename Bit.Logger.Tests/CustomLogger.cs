namespace Bit.Logger.Tests
{
    using Bit.Logger.Config;
    using System;

    public class CustomLogger : ILogger
    {
        public Configuration Configuration { get; }

        public CustomLogger()
        {
            Configuration = new Configuration();
        }

        public void Write<TClass>(string message, Level level) where TClass : class
        {
            Configuration.Format = "LVL:{0:level} SRC:{1:short} MSG:{2} DATE:{3:datetime}";

            Console.WriteLine(
                string.Format(Configuration.FormatProvider, Configuration.Format,
                    level,
                    typeof(TClass).FullName,
                    message,
                    DateTime.Now
                )
            );
        }

        public void Write(string message, Level level)
        {
            Configuration.Format = "LVL:{0:level} MSG:{1} DATE:{2:datetime}";
            
            Console.WriteLine(
                string.Format(Configuration.FormatProvider, Configuration.Format,
                    level,
                    message,
                    DateTime.Now
                )
            );
        }

        public void Write<TClass>(Exception exception, Level level) where TClass : class 
        {
            Configuration.Format = "LVL:{0:level} SRC:{1:short} EX:{2} DATE:{3:datetime}";

            Console.WriteLine(
                string.Format(Configuration.FormatProvider, Configuration.Format,
                    level,
                    exception,
                    typeof(TClass).FullName,
                    DateTime.Now
                )
            );
        }
        public void Write(Exception exception, Level level)
        {
            Configuration.Format = "LVL:{0:level} EX:{1} DATE:{2:datetime}";

            Console.WriteLine(
                string.Format(Configuration.FormatProvider, Configuration.Format,
                    level,
                    exception,
                    DateTime.Now
                )
            );
        }

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class
        {
            Configuration.Format = "LVL:{0:level} SRC:{1:short} MSG:{2} EX:{3} DATE:{4:datetime}";

            Console.WriteLine(
                string.Format(Configuration.FormatProvider, Configuration.Format,
                    level,
                    typeof(TClass).FullName,
                    message,
                    exception,
                    DateTime.Now
                )
            );
        }

        public void Write(string message, Exception exception, Level level)
        {
            Configuration.Format = "LVL:{0:level} MSG:{1} EX:{2} DATE:{3:datetime}";

            Console.WriteLine(
                string.Format(Configuration.FormatProvider, Configuration.Format,
                    level,
                    message,
                    exception,
                    DateTime.Now
                )
            );
        }
    }
}