using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;
using Facebook;


namespace WindowsFormsApp1
{
    public partial class GameOfFacebook : Form
    {
        public GameOfFacebook(List<InfoFriend> i_infoFriends)
        {
            InitializeComponent();
            m_infoFriends = i_infoFriends;
            m_settingsOfGame = new SettingsOfGame(i_infoFriends);
            InitializePicture();
            UpdateQuestionAndAnswers();

        }
        List<InfoFriend> m_infoFriends;
        SettingsOfGame m_settingsOfGame;

        private void UpdateQuestionAndAnswers()
        {
            int Level = m_settingsOfGame.Level;
            labelQuestion.Text = m_settingsOfGame.GetQuestion();
                if(Level == 0)
                {
                    buttonOption1.Text = m_infoFriends[0].Name;
                    buttonOption2.Text = m_infoFriends[1].Name;
                    buttonOption3.Text = m_infoFriends[2].Name;
                }
                else if (Level == 1 )
               {
                buttonOption1.Text = m_infoFriends[0].BirthDay;
                buttonOption2.Text = m_infoFriends[1].BirthDay;
                buttonOption3.Text = m_infoFriends[2].BirthDay;
               }
               else if (Level ==  2)
               {
                buttonOption1.Text = m_infoFriends[0].Gender;
                buttonOption2.Text = m_infoFriends[1].Gender;
                buttonOption3.Hide();
               }
            
            
            //buttonOption1.Text = m_settingsOfGame.get
        }
        private void buttonOption1_Click(object sender, EventArgs e)
        {
            m_settingsOfGame.IfRight(buttonOption1.Text);
            if (m_settingsOfGame.IfGameOver())
            {
                GameOver();
            }
            else
            {
                UpdateQuestionAndAnswers();
            }

        }

        private void InitializePicture()
        {
            pictureBoxProfileFriend.LoadAsync(m_settingsOfGame.GetPicture());

        }

        private void buttonOption2_Click(object sender, EventArgs e)
        {
            m_settingsOfGame.IfRight(buttonOption2.Text);
            if (m_settingsOfGame.IfGameOver())
            {
                GameOver();
            }
            else
            {
                UpdateQuestionAndAnswers();
            }
        }

        private void buttonOption3_Click(object sender, EventArgs e)
        {
            m_settingsOfGame.IfRight(buttonOption3.Text);
            if (m_settingsOfGame.IfGameOver())
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
            string Message = ("U answer Correct " + (m_settingsOfGame.Score / 10) + "/"  + (m_settingsOfGame.CountOfQuestions()));
            MessageBox.Show(Message, "Result", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
