using System;

namespace Handy.Logger.Logger
{
    public class Logger : ILogger
    {
        public void Debug(object message)
        {
            WriteLine(message);
        }

        public void Info(object message)
        {
            WriteLine(message, ConsoleColor.White);
        }

        public void Warning(object message, Exception exception = null)
        {
            WriteLine(message, ConsoleColor.Yellow, exception);
        }

        public void Error(object message, Exception exception = null)
        {
            WriteLine(message, ConsoleColor.DarkRed, exception);
        }

        public void Criticial(object message, Exception exception = null)
        {
            WriteLine(message, ConsoleColor.Red, exception);
        }

        private void WriteLine(object message, ConsoleColor? color = null, Exception exception = null)
        {
            if (color.HasValue)
            {
                Console.ForegroundColor = color.Value;
            }

            if (exception != null)
            {
                message += $" : {exception.Message} : {exception.StackTrace}";
            }

            Console.WriteLine($"{DateTime.UtcNow} - {message}");

            if (color.HasValue)
            {
                Console.ResetColor();
            }
        }
    }
}
