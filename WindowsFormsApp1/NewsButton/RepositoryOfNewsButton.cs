using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RepositoryOfNewsButton
    {
        public List<NewsButton> ListOfNewsButton { get; set; }
        public event Action<DateTime> m_ReportNotify;

       public RepositoryOfNewsButton()
        {
            ListOfNewsButton = new List<NewsButton>();
        }
        public static void  Add(NewsButton i_WebNewsButton)
        {

        }
        public void Notify()
        {
            m_ReportNotify.Invoke(System.DateTime.Now);
        }

    }
}
