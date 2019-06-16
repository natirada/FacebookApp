using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;
using FacebookLogic.feature_2__Game_On_Facebook;
using Facebook;

namespace WindowsFormsApp1
{
    public partial class GameOfFacebook : Form
    {
        public Action<String> command;
        SettingsOfGame settings;
        public GameOfFacebook( IGame i_game)
        {
            InitializeComponent();
            InfoFriends = i_game.InfoFriends;
            SettingsOfGame = i_game;
            InitializePicture();
            UpdateQuestionAndAnswers();
            if(SettingsOfGame is SettingsOfGame)
            {
               settings = SettingsOfGame as SettingsOfGame;
            }
      
        
        }

        public List<InfoFriend> InfoFriends { get; set; }

        public IGame SettingsOfGame { get; set; }

        private void UpdateQuestionAndAnswers()
        {
            labelQuestion.Text = SettingsOfGame.GetQuestion();
            buttonOption1.Text = SettingsOfGame.GetAnswers();
            buttonOption2.Text = SettingsOfGame.GetAnswers();
            buttonOption3.Text = SettingsOfGame.GetAnswers();
        }

        private void InitializePicture()
        {
            pictureBoxProfileFriend.LoadAsync(SettingsOfGame.GetPicture());
        }

        private void buttonOption1_Click(object sender, EventArgs e)
        {
            command = settings.FirstLevel;
            action(buttonOption1.Text);  
        }

        private void buttonOption2_Click_1(object sender, EventArgs e)
        {
            command = settings.SecondLevel;
            action(buttonOption2.Text);
        }

        private void buttonOption3_Click(object sender, EventArgs e)
        {
            command = settings.ThiredLevel;
            action(buttonOption3.Text);
        }

        private void action(String i_Answer)
        {
            command(i_Answer);
            checkIfGameOver();
        }


        private void checkIfGameOver()
        {
            if (SettingsOfGame.IfGameOver())
            {
                GameOver();
            }
            else
            {
                UpdateQuestionAndAnswers();
            }
        }

        private void GameOver()
        {
            string Message = "Your answer correct : " + (SettingsOfGame.Score / 10) + "/"  + SettingsOfGame.CountOfQuestions();
            MessageBox.Show(Message, "Result", MessageBoxButtons.OK);
            this.Close();
        }

       
    }
}
