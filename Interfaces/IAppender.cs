namespace Logger.Interfaces
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        ILayout Layout { get; set; }

        void AppendMessage(string message, ReportLevel error);
    }
}
