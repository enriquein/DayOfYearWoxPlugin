using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Wox.Plugin;

namespace DayOfYearWoxPlugin
{
    public class Main : IPlugin
    {
        public void Init(PluginInitContext context)
        {
        }

        public List<Result> Query(Query query)
        {
            var day = DateTime.Now.DayOfYear.ToString();

            var result = new Result
            {
                Title = "Day Of Year",
                SubTitle = day
            };

            result.Action = e =>
            {
                Clipboard.SetText(day);
                return true;
            };

            return new List<Result> { result };
        }
    }
}