using System;
using System.Collections.Generic;
using System.Windows;

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
            Title = "DateTime to clipboard",
            Action = c =>
            {
                //_context.API.ShowMsg(
                //    "titel",
                //    "subtitel");
                Clipboard.SetText(DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss"));
                return true;
            },
            IcoPath = "icon.png"
        };
        return new List<Result> { result };
    }
}