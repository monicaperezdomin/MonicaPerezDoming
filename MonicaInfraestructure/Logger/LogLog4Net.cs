using log4net;
using System;

namespace MonicaInfraestructure.Logger
{
    public class LogggerLog4Net : ILogger
    {
      

        public void Error(string message, object target)
        {
            LogManager.GetLogger(target.GetType()).Error(message);
        }

        public void Error(string message, Exception exception, object target)
        {
            LogManager.GetLogger(target.GetType()).Error(message, exception);
        }

        public void Fatal(string message, object target)
        {
            LogManager.GetLogger(target.GetType()).Fatal(message);
        }

        public void Fatal(string message, Exception exception, object target)
        {
            LogManager.GetLogger(target.GetType()).Fatal(message, exception);
        }

        

        public void Warn(string message, object target)
        {
            LogManager.GetLogger(target.GetType()).Warn(message);
        }
    }
}
