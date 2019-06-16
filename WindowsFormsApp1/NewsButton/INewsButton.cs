using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class NewsButton : WebBrowser
    {
        public DateTime DateTimeOfNews { get; set; }
        void UpdateNews(DateTime i_dateTime)
        {

        }
    }
}
