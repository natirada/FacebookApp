using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public  class ForecastNews:  NewsButton
    {
        public  ForecastNews()
        {
            this.Navigate("https://www.weatherbug.com/weather-forecast/10-day-weather/");
        }
        public void UpdateNews(DateTime i_dateTime)
        {
            this.Navigate("https://www.weatherbug.com/weather-forecast/10-day-weather/");
            DateTimeOfNews = i_dateTime;
            //this.Refresh();
            //Invalidate();
            //this.Invalidate();
        }
    }
}

