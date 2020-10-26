using System;

namespace Handy.Logger.Logger
{
    public interface ILogger
    {
        void Debug(object message);
        void Info(object message);
        void Warning(object message, Exception exception = null);
        void Error(object message, Exception exception = null);
        void Criticial(object message, Exception exception = null);
    }
}
