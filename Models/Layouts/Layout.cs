namespace Logger.Models.Layouts
{
    using Interfaces;

    public abstract class Layout : ILayout
    {
        public string Format { get; set; }

        public abstract void CreateFormat(string message, ReportLevel error);
    }
}
