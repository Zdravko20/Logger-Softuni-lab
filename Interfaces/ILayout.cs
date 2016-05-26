namespace Logger.Interfaces
{
    public interface ILayout
    {
        string Format { get; set; }

        void CreateFormat(string message, ReportLevel error);
    }
}
