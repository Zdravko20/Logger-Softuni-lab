namespace Logger.Models.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void AppendMessage(string message, ReportLevel error)
        {
            bool check = this.ChekReportLevel(error);
            if (check)
            {
                Layout.CreateFormat(message, error);
                Console.WriteLine(Layout.Format);
            }
        }
    }
}
