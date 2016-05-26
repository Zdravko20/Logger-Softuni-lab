namespace Logger.Models.Appenders
{
    using Interfaces;

    public abstract class Appender : IAppender
    {
        private const ReportLevel DefaultReportLevel = ReportLevel.Error;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel ReportLevel { get; set; } = DefaultReportLevel;
        public ILayout Layout { get; set; }

        public abstract void AppendMessage(string message, ReportLevel error);

        protected bool ChekReportLevel(ReportLevel error)
        {
            bool check = (int)this.ReportLevel <= (int)error;
            if (check)
            {
                this.ReportLevel = error;
            }

            return check;
        }
    }
}