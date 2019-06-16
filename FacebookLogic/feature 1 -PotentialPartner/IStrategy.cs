using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.feature_1__PotentialPartner
{
    public interface IStrategy
    {
        int Action(int i_AmountOfLikes);
    }
}
