using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.feature_2__Game_On_Facebook
{
     public class ProxyAdvancedSettingsOfGame : IGame
    {
        private SettingsOfGame SettingsOfGame;

        public int Score
        {
            get { return SettingsOfGame.Score; }

            set { SettingsOfGame.Score = Score; }
        }

        public int Level
        {
            get { return SettingsOfGame.Level; }
            set { SettingsOfGame.Level = Score; }
        }
        public List<InfoFriend> InfoFriends {
            get { return SettingsOfGame.InfoFriends; }
            set { SettingsOfGame.InfoFriends = InfoFriends; }
        }

        public ProxyAdvancedSettingsOfGame(List<InfoFriend> i_InfoFriends)
        {
            SettingsOfGame = new SettingsOfGame(i_InfoFriends);
            SettingsOfGame.r_Questions.Add("What is The Locale of your friend");
            SettingsOfGame.r_Questions.Add("What is The Email of your friend");
            SettingsOfGame.r_Questions.Add("What is The Religion of your friend");
        }

        public void IfRight(string i_Answer)
        {
            bool v_flag = false;
            if (SettingsOfGame.Level < 3)
            {
                SettingsOfGame.IfRight(i_Answer);
            }
            else if(SettingsOfGame.Level == 3)
            {
                if (SettingsOfGame.InfoFriends[SettingsOfGame.ChooseFriend].Locale != null)
                {
                    if (SettingsOfGame.InfoFriends[SettingsOfGame.ChooseFriend].Locale.Equals(i_Answer))
                    {
                        v_flag = true;
                    }
                }
            }
            else if (SettingsOfGame.Level == 4)
            {
                if (SettingsOfGame.InfoFriends[SettingsOfGame.ChooseFriend].Email != null)
                {
                    if (SettingsOfGame.InfoFriends[SettingsOfGame.ChooseFriend].Email.Equals(i_Answer))
                    {
                        v_flag = true;
                    }
                }
            }
            else if (SettingsOfGame.Level == 5)
            {
                if (SettingsOfGame.InfoFriends[SettingsOfGame.ChooseFriend].Religion != null)
                {
                    if (SettingsOfGame.InfoFriends[SettingsOfGame.ChooseFriend].Religion.Equals(i_Answer))
                    {
                        v_flag = true;
                    }
                }   
            }

            if (SettingsOfGame.Level >= 3)
            {
                UpDateGameOver(v_flag);
            }
        }

        public string GetAnswers()
        {
            string str = string.Empty;
            if (SettingsOfGame.Level < 3)
            {
                return SettingsOfGame.GetAnswers();
            }
            else if (SettingsOfGame.Level == 3)
            {
                str = SettingsOfGame.InfoFriends[SettingsOfGame.CurrentAnswers].Locale;
            }
            else if (SettingsOfGame.Level == 4)
            {
                str = SettingsOfGame.InfoFriends[SettingsOfGame.CurrentAnswers].Email;
            }
            else if (SettingsOfGame.Level == 5)
            {
                str = SettingsOfGame.InfoFriends[SettingsOfGame.CurrentAnswers].Religion;
            }

            SettingsOfGame.CurrentAnswers = (SettingsOfGame.CurrentAnswers + 1) % 2;
            return str;
        }

        public void Start()
        {
            SettingsOfGame.Start();
        }

        public int CountOfQuestions()
        {
           return SettingsOfGame.CountOfQuestions();
        }

        public string GetQuestion()
        {
            return SettingsOfGame.GetQuestion();
        }

        public string GetPicture()
        {
            return SettingsOfGame.GetPicture();
        }

        public void UpDateGameOver(bool i_flag)
        {
            SettingsOfGame.UpDateGameOver(i_flag);
        }

        public bool IfGameOver()
        {
            return SettingsOfGame.IfGameOver();
        }
    }
}
