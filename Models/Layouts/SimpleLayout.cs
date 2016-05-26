namespace Logger.Models.Layouts
{
    using System;

    public class SimpleLayout : Layout
    {
        public override void CreateFormat(string message, ReportLevel error)
        {
            this.Format = $"{DateTime.Now} - {error} - {message}";
        }
    }
}