using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using FacebookLogic.feature_1__PotentialPartner;

namespace FacebookLogic
{
    public class PotentialPartner
    {
        private IStrategy m_strategy;

        public PotentialPartner(List<InfoFriend> i_InfoFriendOfTheUser, User i_LoggedInUser, IStrategy i_strategy)
        {
            AddUSerFriendsMadeLikeInAPhoto(i_LoggedInUser, i_InfoFriendOfTheUser);
            m_strategy = i_strategy;
        }

        public void Sort(List<InfoFriend> i_InfoFriends)
        {
            i_InfoFriends.Sort();
        }

        public void AddUSerFriendsMadeLikeInAPhoto(User i_LoggedInUser, List<InfoFriend> i_InfoFriends)
        {
            FacebookObjectCollection<Album> allAlbumsOfTheLoggedInUser = i_LoggedInUser.Albums;
            foreach (Album album in allAlbumsOfTheLoggedInUser)
            {
                FacebookObjectCollection<Photo> allThePhotoOffTheLoggedInUser = album.Photos;

                foreach (Photo photo in allThePhotoOffTheLoggedInUser)
                {
                    FacebookObjectCollection<User> allTheFriendOfTheLoggedInUserThatLikeAPhoto = photo.LikedBy;

                    foreach (User user in allTheFriendOfTheLoggedInUserThatLikeAPhoto)
                    {
                        if (((i_LoggedInUser.Gender == User.eGender.male) && (user.Gender == User.eGender.female)) || ((i_LoggedInUser.Gender == User.eGender.female) && (user.Gender == User.eGender.male)))
                        {
                            MacthPartner(user, i_InfoFriends);
                        }
                    }
                }
            }
        }

            public void MacthPartner(User i_LoggedInUser, List<InfoFriend> i_InfoFriends)
            {
                    foreach (InfoFriend friend in i_InfoFriends)
                    {
                        if (friend.Name == i_LoggedInUser.Name)
                        {
                         m_strategy.Action(friend.AmountOfLikes);
                        }
                    }
            }
    }
}
