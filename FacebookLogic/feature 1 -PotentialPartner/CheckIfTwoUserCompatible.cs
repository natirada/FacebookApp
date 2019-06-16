using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class CheckIfTwoUserCompatible 
    {
        public CheckIfTwoUserCompatible(User i_FirstUser, User i_SecondUser)
        {
            CheckCommonPoint(i_FirstUser, i_SecondUser);
        }

        public static bool CheckCommonPoint(User i_FirstUser, User i_SecondUser)
        {
            int commonPoint = 0;

            bool v_IsCompatible = false;

            if (i_FirstUser.Gender != i_SecondUser.Gender)
            {
                commonPoint++;
            }

            if (i_FirstUser.Religion == i_SecondUser.Religion)
            {
                commonPoint++;
            }

            if (i_FirstUser.Location == i_SecondUser.Location)
            {
                commonPoint++;
            }

            if(commonPoint == 3)
            {
                v_IsCompatible = true;
            }

            return v_IsCompatible;
        }
    }
}
