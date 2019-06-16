using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using FacebookWrapper.ObjectModel;
using FacebookLogic;
using FacebookLogic.feature_2__Game_On_Facebook;

namespace WindowsFormsApp1
{
    public partial class MainPageOfFacebook : Form
    {
        public MainPageOfFacebook()
        {
            InitializeComponent();
            Initialize();
            LoadComponentsOfUserProfile();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }
        public ICommand m_ICommand;
        public User LoggedInUser { get; set; }
        public RepositoryOfNewsButton RepositoryOfNewsButton { get; set; }
        private void Initialize()
        {
            LoggedInUser = SingleTonLoggedInUser.GetInstance();
            profilPicture.LoadAsync(LoggedInUser.PictureSmallURL);
            string status = string.Format("Whats'on your mind, {0}?", LoggedInUser.FirstName);
            textBoxStatus.Text = status;
            RepositoryOfNewsButton = new RepositoryOfNewsButton();
            InitializeNewsButton();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            FacebookWrapper.FacebookService.Logout(() => { });
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status updateStatus = LoggedInUser.PostStatus(textBoxStatus.Text);
            MessageBox.Show("Status Posted! ID: " + updateStatus.Id);
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            
        }

        private void linkPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPages();
        }

        private void fetchPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            foreach (Page page in LoggedInUser.LikedPages)
            {
                listBoxPages.Items.Add(page);
            }

            if (LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void buttonOfListOfPotentialPartner_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = LoggedInUser.Friends;
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            GameOfFacebook gameOfFacebook = new GameOfFacebook(new SettingsOfGame(SingleTonLoggedInUser.s_ListOfFriendsOfTheLoginUser));
            gameOfFacebook.ShowDialog();
        }

        public void fetchPage()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            //foreach (Page page in LoggedInUser.LikedPages)
            //{
            //     listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(page)));
            //}

            //if (LoggedInUser.LikedPages.Count == 0)
            //{
            //    MessageBox.Show("No liked pages to retrieve :(");
            //}
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void InsertPictureToPanel(List<string> i_ListOfPhotosToPrint, Panel panel)
        {
                const int x_count = 83;
                const int y_count = 68;
                int m_x = 3;
                int m_y = 4;
                int i = 0;
                int k = 0;
           
                foreach (string photo in i_ListOfPhotosToPrint)
                {
                if (k < 3)
                {
                    PictureBox pictureBox = new PictureBox();

                    pictureBox.Size = new System.Drawing.Size(81, 61);
                    pictureBox.Left = m_x;
                    pictureBox.Top = m_y;

                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Load(photo);

                    panel.Invoke(new Action(() => panel.Controls.Add(pictureBox)));
                    i = (i + 1) % 3;
                    if (i == 0)
                    {
                        m_y += y_count;
                        m_x = 3;
                    }
                    else
                    {
                        m_x += x_count;
                    }
                    k++;
                }
            }
        }

        private void LoadComponentsOfUserProfile()
        {
            new Thread(fetchPage).Start();

            Thread photosOfMyFriendThread = new Thread(new ThreadStart(() => { InsertPictureToPanel(SingleTonLoggedInUser.s_photosOfFriend, panelFriends); }));
            photosOfMyFriendThread.Start();

            Thread myPhtotosThread = new Thread(new ThreadStart(() => { InsertPictureToPanel(SingleTonLoggedInUser.s_UrlOfPhotosOfTheUser, panelMyPhotos); }));
            myPhtotosThread.Start();
        }

        private void bioTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            User userSelcted = listBoxProbablyPartner.SelectedItem as User;
            if (userSelcted != null)
            {
               // userSelcted.Bio = bioTextBox.Text;
            }
        }

        private void checkBoxCompatible2Friends_CheckedChanged(object sender, EventArgs e)
        {
            DisplayListboxItems();
            checkBoxCheckUniqueFriendCompatible.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DisplayListboxItems();
            checkBoxCompatible2Friends.Enabled = false;
        }

        private void DisplayListboxItems()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                listBoxCompatible.Items.Add(friend);
                listBoxCompatible.DisplayMember = "Name";
            }
        }

        public static int s_I;

        private void listBoxCompatible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s_I == 1)
            {
                bool v_result = false;
                if (checkBoxCompatible2Friends.Checked)
                {
                    AdapterToCheckIfTwoPersonCompatible adapterToCheckIfTwoPersonCompatible = new AdapterToCheckIfTwoPersonCompatible();
                    v_result = adapterToCheckIfTwoPersonCompatible.CheckCommonPoint(listBoxCompatible.SelectedItem as User);
                }
                else
                {
                    listBoxCompatible.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
                    v_result = CheckIfTwoUserCompatible.CheckCommonPoint(listBoxCompatible.SelectedItem as User, listBoxCompatible.SelectedItem as User);
                }

                if (!v_result)
                {
                    MessageBox.Show("The Friends Are Not Compatible");
                }
                else
                {
                    MessageBox.Show("The Friends Are  Compatible");
                }
            }

            s_I++;
        }
        

        public void RemoveAFriend()
        {
            Control.ControlCollection pic = panelFriends.Controls;
            panelFriends.Controls.Remove(pic[0]);
            Invalidate();
        }

        private void ButtonRemoveFriend_Click(object sender, EventArgs e)
        {
            RemoveAFriend();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void InitializeNewsButton()
        {
            List<Control> listOfNewsButton = new List<Control>();
            ForecastNews forecastNews = new ForecastNews();
            NewsBrowser newsBrowser = new NewsBrowser();
            ForeignExchangeNews foreignExchangeNews = new ForeignExchangeNews();
            RepositoryOfNewsButton.m_ReportNotify += forecastNews.UpdateNews;
            RepositoryOfNewsButton.m_ReportNotify += newsBrowser.UpdateNews;
            RepositoryOfNewsButton.m_ReportNotify += foreignExchangeNews.UpdateNews;

            listOfNewsButton.Add(forecastNews);
            listOfNewsButton.Add(newsBrowser);
            listOfNewsButton.Add(foreignExchangeNews);
            InsertControlToPanel(panel2,listOfNewsButton);
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RepositoryOfNewsButton.Notify();
            foreach (NewsButton NewsButton in panel2.Controls)
            {
                listBox1.Items.Add( String.Format("{0} UPDATED ON  : {1} ", NewsButton.GetType().Name,NewsButton.DateTimeOfNews.TimeOfDay.ToString()));
            }
        }

        private void InsertControlToPanel(Panel i_Panel, List<Control> i_ListOfControlToInsertInPanel)
        {
            const int x_count =250;
            const int y_count = 68;
            int m_x = 3;
            int m_y = 4;
            int i = 0;
            foreach (Control control in i_ListOfControlToInsertInPanel)
            {
                control.Left = m_x;
                control.Top = m_y;
                i_Panel.Controls.Add(control);


                i = (i + 1) % 3;
                if (i == 0)
                {
                    m_y += y_count;
                    m_x = 3;
                }
                else
                {
                    m_x += x_count;
                }
            }
        }

        private void webBrowserForecast_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPageOfFacebook_Load(object sender, EventArgs e)
        {

        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {

         //   m_ICommand.Execute();
            GameOfFacebook gameOfFacebook = new GameOfFacebook(new SettingsOfGame(SingleTonLoggedInUser.s_ListOfFriendsOfTheLoginUser));
            gameOfFacebook.ShowDialog();
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GameOfFacebook gameOfFacebook = new GameOfFacebook(new SettingsOfGame(SingleTonLoggedInUser.s_ListOfFriendsOfTheLoginUser));
            gameOfFacebook.ShowDialog();
        }

        private void picfacebook_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
