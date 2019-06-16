using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using Facebook;
using FacebookWrapper;

namespace FacebookLogic
{
    public static class SingleTonLoggedInUser
    {
        private static readonly object sr_CreationLock = new object();
        private static User s_UserInstance;
        public static  List<InfoFriend> s_ListOfFriendsOfTheLoginUser { get; set; }
        public static List<string> s_UrlOfPhotosOfTheUser = new List<string>();
        public static List<string> s_photosOfFriend = new List<string>();

        public static User GetInstance()
        {
            if (s_UserInstance == null)
            {
                lock (sr_CreationLock)
                {
                    if (s_UserInstance == null)
                    {
                        loginAndInit();
                        CreateListOfLoginUserFriends();
                        AddPhotosFromAlbumToList();
                        AAddPhotosFromFriendToList();
                        
                    }
                }
            }

            return s_UserInstance;
        }

        public static void loginAndInit()
        {
            /// Owner: design.patterns
            ///System.Diagnostics.Process.Start("CMD.exe", "/C RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2");
            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
            LoginResult result = FacebookService.Login(
                "2449966815019268",
                "public_profile",
                "user_birthday",
                "user_gender",
                "user_friends",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_tagged_places",
                "user_videos",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages");

            // These are NOT the complete list of permissions. Other permissions for example:
            // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
            // The documentation regarding facebook login and permissions can be found here: 
            ///https://developers.facebook.com/docs/facebook-login/permissions#reference

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                s_UserInstance = result.LoggedInUser;
            }
            else
            {
                throw new Exception();
            }
        }

        private static void CreateListOfLoginUserFriends()
        {
            s_ListOfFriendsOfTheLoginUser = new List<InfoFriend>();
            foreach (User user in s_UserInstance.Friends)
            {
                InfoFriend infoFriend = new InfoFriend();
                infoFriend.Name = user.Name;
                infoFriend.BirthDay = user.Birthday;
                infoFriend.Gender = User.eGender.female == user.Gender ? "female" : "male";
                infoFriend.AmountOfLikes = 0;
                infoFriend.Picture = user.PictureNormalURL;
                infoFriend.Locale = user.Locale;
                infoFriend.Email = user.Email;
                infoFriend.Religion = user.Religion;
                s_ListOfFriendsOfTheLoginUser.Add(infoFriend);
            }
        }

        private static void AddPhotosFromAlbumToList()
        {
            Album albums = s_UserInstance.Albums[0];

            foreach (Photo photo in albums.Photos)
            {
                s_UrlOfPhotosOfTheUser.Add(photo.PictureNormalURL);
            }

        }

        private static  void AAddPhotosFromFriendToList()
        {
            
            foreach (User friend in s_UserInstance.Friends)
            {
                if (friend.Name == "Desig Patter")
                {
                    s_photosOfFriend.Add("https://scontent.flhr5-1.fna.fbcdn.net/v/t1.0-9/1235245_381188762010484_1662688945_n.jpg?_nc_cat=104&_nc_ht=scontent.flhr5-1.fna&oh=c6d95763d8047b6014518354d5e3b5cc&oe=5CF2D914");
                }
                else
                {
                    s_photosOfFriend.Add(friend.PictureNormalURL);
                }
            }
        }
    }
}

