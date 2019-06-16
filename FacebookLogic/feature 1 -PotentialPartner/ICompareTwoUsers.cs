using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public interface ICompareTwoUsers
    {
      bool CheckCommonPoint(User i_UniqueUser);
    }
}
