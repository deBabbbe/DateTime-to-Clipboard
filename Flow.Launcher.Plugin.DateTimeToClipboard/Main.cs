using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Flow.Launcher.Plugin.DateTimeToClipboard;

public class DateTimeToClipboard : IPlugin, ISettingProvider
{
    private PluginInitContext _context;

    public Control CreateSettingPanel()
    {
        var control = new ConfigurationView();
        return control;
    }

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