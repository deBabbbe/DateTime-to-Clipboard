using System.Collections.Generic;

namespace Flow.Launcher.Plugin.DateTimeToClipboard;

public class DateTimeToClipboard : IPlugin
{
    private PluginInitContext _context;

    public void Init(PluginInitContext context)
    {
        _context = context;

    }

    public List<Result> Query(Query query)
    {
        var result = new Result
        {
            Title = "Hello World from CSharp",
            SubTitle = $"Query: {query.Search}",
            Action = c =>
            {
                _context.API.ShowMsg(
                    "titel",
                    "subtitel");
                return true;
            },
            IcoPath = "Images/app.png"
        };
        return new List<Result> { result };
    }
}