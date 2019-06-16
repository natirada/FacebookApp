using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace WindowsFormsApp1
{
    public partial class HomePageOfFacebook : Form
    {
        public User m_LoggedInUser;
       
        public HomePageOfFacebook()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPageOfFacebook mainPageOfFacebook = new MainPageOfFacebook();
            mainPageOfFacebook.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                this.Hide();
                MainPageOfFacebook mainPageOfFacebook = new MainPageOfFacebook();
                mainPageOfFacebook.ShowDialog();
        }

    }
}
