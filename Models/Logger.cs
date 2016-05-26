namespace Logger.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appender)
        {
            this.Appenders = new List<IAppender>(appender);
        }

        public IEnumerable<IAppender> Appenders { get; set; }

        public virtual void Info(string message)
        {
            this.Append(message, ReportLevel.Info);
        }

        public virtual void Warn(string message)
        {
            this.Append(message, ReportLevel.Warn);
        }

        public virtual void Error(string message)
        {
            this.Append(message, ReportLevel.Error);
        }

        public virtual void Critical(string message)
        {
            this.Append(message, ReportLevel.Critical);
        }

        public virtual void Fatal(string message)
        {
            this.Append(message, ReportLevel.Fatal);
        }

        public virtual void Append(string message, ReportLevel error)
        {
            foreach (var appender in this.Appenders)
            {
                appender.AppendMessage(message, error);
            }
        }
    }
}