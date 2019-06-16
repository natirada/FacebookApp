using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ForeignExchangeNews : NewsButton
    {
        public ForeignExchangeNews()
        {
            this.Navigate("https://en.globes.co.il/serveen/fcurrency/historyrates.asp");
        }
        public void UpdateNews(DateTime i_dateTime)
        {
            this.Navigate("https://en.globes.co.il/serveen/fcurrency/historyrates.asp");
            DateTimeOfNews = i_dateTime;
           
        }
    }
}
