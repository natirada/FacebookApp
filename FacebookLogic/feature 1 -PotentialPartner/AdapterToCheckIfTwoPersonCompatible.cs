using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class AdapterToCheckIfTwoPersonCompatible : ICompareTwoUsers
    {
        public bool CheckCommonPoint(User i_UniqueUser)
        {
           return CheckIfTwoUserCompatible.CheckCommonPoint(i_UniqueUser, SingleTonLoggedInUser.GetInstance());
        }
    }
}
