using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public class NewsBrowser: NewsButton
    {
        
        public NewsBrowser()
        {
            this.Navigate("https://news.google.com/?hl=en-US&gl=US&ceid=US:en");
        }
        public void UpdateNews(DateTime i_dateTime)
        {
            this.Navigate("https://news.google.com/?hl=en-US&gl=US&ceid=US:en");
            base.DateTimeOfNews = i_dateTime;
        }
    }
}
