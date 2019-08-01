using System;


namespace MonicaInfraestructure.Logger
{
    public interface ILogger
    {
      
        void Warn(String message, object target);
        void Error(String message, object target);
        void Error(String message, Exception exception, object target);
        void Fatal(String message, object target);
        void Fatal(String message, Exception exception, object target);
    }
}