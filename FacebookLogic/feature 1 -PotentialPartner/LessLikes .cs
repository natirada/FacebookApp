using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.feature_1__PotentialPartner
{
    public class LessLikes : IStrategy
    {
        public int Action(int i_AmountOfLikes)
        {
            return --i_AmountOfLikes;
        }
    }
}
