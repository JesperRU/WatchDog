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

namespace WD_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendMessage(object sender, FileSystemEventArgs e)
        {
            string password = ""; // пароль
            var vkApi = new VkApi();
            vkApi.Authorize(@params: new ApiAuthParams
            {
                ApplicationId = 0,
                Login = "",
                Password = password,
                Settings = Settings.All
            });
            //long id = 0;

            //if (Chats.Chats.Count != 0)
            //{
            //    id = Chats.Chats[0].Id;
            //}
            //else
            //{

            //    return;
            //}
            DateTime DT = DateTime.Now;
            var send = vkApi.Messages.Send(@params: new MessagesSendParams
            {
                UserId = 0,
                Message = DT.ToString("yyyy.MM.dd HH.mm.ss") + " "+ e.Name + " " + e.ChangeType

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = folderBrowserDialog1.SelectedPath;
                var WatchDog = new FileSystemWatcher(Path);

                WatchDog.Changed += SendMessage;
                WatchDog.Created += SendMessage;
                WatchDog.Deleted += SendMessage;
                WatchDog.Renamed += SendMessage;

                WatchDog.EnableRaisingEvents = true;
                WatchDog.WaitForChanged(WatcherChangeTypes.All);
            }



        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
