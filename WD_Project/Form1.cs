using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model.RequestParams;
using System.IO;
using System.Text.RegularExpressions;
using VkNet.Exception;

namespace WD_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private VkApi Api;

        private void AuthorizeMe()
        {
            try
            {
                string password = Password.Text;
                string email = Email.Text;
                Api = new VkApi();
                Api.Authorize(new ApiAuthParams
                {
                    ApplicationId = 6139393,
                    Login = email,
                    Password = password,
                    Settings = Settings.All
                });
            }
            catch ( VkApiAuthorizationException)
            {
                AuthStatus.Text = "Auth faild. Wrong Email or password.";
            }
            AuthStatus.Text = "Auth Success.";
            AuthStatus.ForeColor = Color.Green;
            ActionStart.Enabled = true;
        }


        private void SendMessage(object sender, FileSystemEventArgs e)
        {
            DateTime DT = DateTime.Now;
            var send = Api.Messages.Send(@params: new MessagesSendParams
            {
                UserId = Api.UserId,
                Message = DT.ToString("yyyy.MM.dd HH.mm.ss") + " "+ e.FullPath + " " + e.ChangeType
            });
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string path = PathDisplay.Text;
            var watchDog = new FileSystemWatcher(path);
            watchDog.Changed += SendMessage;
            watchDog.Created += SendMessage;
            watchDog.Deleted += SendMessage;
            watchDog.Renamed += SendMessage;

            watchDog.EnableRaisingEvents = true;
            watchDog.WaitForChanged(WatcherChangeTypes.All);
            Hide();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Browser_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PathDisplay.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void AuthMe_Click(object sender, EventArgs e)
        {
            AuthorizeMe();
        }
    }
}
