namespace Logger.Models.Appenders
{
    using System.IO;
    using Interfaces;

    public class FileAppender : Appender, IFileAppender
    {
        private const string DefaultPath = "D:\\log.txt";

        public FileAppender(ILayout layout, string path = DefaultPath) : base(layout)
        {
            this.File = path;
        }

        public string File { get; set; }

        public override void AppendMessage(string message, ReportLevel error)
        {
            bool check = this.ChekReportLevel(error);
            if (check)
            {
                StreamWriter writer = new StreamWriter(this.File, true);
                using (writer)
                {
                    this.Layout.CreateFormat(message, error);
                    writer.WriteLine(this.Layout.Format, true);
                }
            }
        }
    }
}