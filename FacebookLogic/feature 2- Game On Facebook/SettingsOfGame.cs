using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookLogic.feature_2__Game_On_Facebook;

namespace FacebookLogic
{
    public class SettingsOfGame : IGame
    {
        public readonly List<string> r_Questions = new List<string>() { "What is The name of your friend ?", "What is the birthday of your friend ?", "What is the gender of your friend ?" };

        public int NumOfQuestion
        {
            get
            {
                return NumOfQuestion;
            }

            private set
            {
                NumOfQuestion = InfoFriends.Count;
            }
        }

        public int Score
        {
            get; set;
        }

        public int Level { get; set; }

        public int ChooseFriend { get; set; }

        internal List<InfoFriend> InfoFriends { get; set; }
        List<InfoFriend> IGame.InfoFriends { get; set; }

        private bool GameOver = false;

        public int CurrentAnswers;

        public SettingsOfGame(List<InfoFriend> i_InfoFriends)
        {
            InfoFriends = i_InfoFriends;
            CurrentAnswers = 0;
            
            Start();
        }

        public void Start()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            ChooseFriend = random.Next(0, r_Questions.Count -1);
        }

        public int CountOfQuestions()
        {
            return r_Questions.Count;
        }

        public string GetQuestion()
        {
            if (Level <= r_Questions.Count - 1)
            {
                return r_Questions[Level];
            }
            else
            {
                return null;
            }
        }

        public string GetPicture()
        {
            return InfoFriends[ChooseFriend].Picture;
        }
        bool v_flag = false;
//=============================================================================
        public void FirstLevel(string i_Answer)
        {
            v_flag = false;
            if (InfoFriends[ChooseFriend].Name.Equals(i_Answer))
            {
                v_flag = true;
            }
            UpDateGameOver(v_flag);
        }

        public void SecondLevel(string i_Answer)
        {
            v_flag = false;
            if (InfoFriends[ChooseFriend].Name.Equals(i_Answer))
            {
                v_flag = true;
            }
            UpDateGameOver(v_flag);
        }

        public void ThiredLevel(string i_Answer)
        {
            v_flag = false;
            if (InfoFriends[ChooseFriend].Name.Equals(i_Answer))
            {
                v_flag = true;
            }
            UpDateGameOver(v_flag);
        }

        public virtual void IfRight(string i_Answer)
        {
            bool v_flag = false;
            
            if(Level == 0 )
            {
                if (InfoFriends[ChooseFriend].Name.Equals(i_Answer))
                {
                    v_flag = true;
                }
            }

            if (Level == 1 )
            {
                if (InfoFriends[ChooseFriend].BirthDay.Equals(i_Answer))
                {
                    v_flag = true;
                }
            }

            if (Level == 2 )
            {
                if (InfoFriends[ChooseFriend].Gender.Equals(i_Answer))
                {
                    v_flag = true;
                }
            }

            UpDateGameOver(v_flag);
        }

        public void UpDateGameOver(bool i_flag)
        {
            if (i_flag)
            {
                Score += 10;
            }

            this.Level++;
            if (Level > r_Questions.Count - 1)
            {
                GameOver = true;
            }
        }

        public bool IfGameOver()
        {
            return GameOver;
        }

        public virtual string GetAnswers()
        {
            string str = string.Empty;

            if (Level == 0)
            {
                str = InfoFriends[CurrentAnswers].Name;
            }
            else if (Level == 1)
            {
                str = InfoFriends[CurrentAnswers].BirthDay;
            }
            else if (Level == 2)
            {
              str = InfoFriends[CurrentAnswers].Gender;
            }

            CurrentAnswers = (CurrentAnswers + 1) % 2;
           
            return str;
        }
    }
}
