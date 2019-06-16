using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic.feature_2__Game_On_Facebook
{
    public interface IGame
    {
        void Start();

        int CountOfQuestions();

        string GetQuestion();

        string GetPicture();

        void IfRight(string i_Answer);

        void UpDateGameOver(bool i_flag);

        bool IfGameOver();

        string GetAnswers();

        int Level { get; set; }

        int Score { get; set; }

        List<InfoFriend> InfoFriends { get; set; }
    }
}
