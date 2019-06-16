using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using Facebook;
namespace FacebookLogic
{
    public class InfoFriend : IComparable
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public int AmountOfLikes { get; set; }

        public string BirthDay { get; set; }

        public string Picture { get; set; }

        public string Locale { get; set; }

        public string Email { get; set; }

        public string Religion { get; set; }

        public int CompareTo(object obj)
        {
            InfoFriend other = (InfoFriend)obj;
            if (this.AmountOfLikes > other.AmountOfLikes)
            {
                return 1;
            }
            else if (this.AmountOfLikes < other.AmountOfLikes)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
      
    }
}
