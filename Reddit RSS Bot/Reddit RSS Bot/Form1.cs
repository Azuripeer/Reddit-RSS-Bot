using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedditSharp;
using RedditSharp.Things;

namespace Reddit_RSS_Bot
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        private int interval;
        private bool NSFW;
        private List<RSSFeed> feeds = new List<RSSFeed>();
        private Reddit reddit;
        private Subreddit subreddit;

        public Form1()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timerEventProcessor);
        }

        private void addFeedButton_Click(object sender, EventArgs e)
        {
            Uri uriResult;
            bool isURL = Uri.TryCreate(feedTextBox.Text, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
            bool exists = feeds.Exists(x => x.getURL() == feedTextBox.Text);
            bool isEmpty = feedTextBox.Text == String.Empty;
            if (isURL && !exists && !isEmpty)
            {
                feedTextBox.BackColor = Color.White;
                feeds.Add(new RSSFeed(feedTextBox.Text));                          //Create a new RSSFeed and add it to the list
                feedsListBox.Items.Add(feedTextBox.Text);                          //Add the URI to the feedsListBox
                feedTextBox.Text = String.Empty;                                   //Reset the textbox
            }
            else
            {
                feedTextBox.BackColor = Color.Red;
            }
        }

        private void feedsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                int index = feedsListBox.SelectedIndex;
                if(index >= 0)                                                  //SelectedIndex is -1 when nothing is selected
                {
                    feeds.RemoveAt(feedsListBox.SelectedIndex);                 //Remove the RSSFeed object from the feeds list
                    feedsListBox.Items.Remove(feedsListBox.SelectedItem);       //Remove the URI from the feedsListBox
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (parseInput())
            {
                timer.Start();
            }
        }

        private void timerEventProcessor(object sender, EventArgs e)
        {
            foreach(RSSFeed feed in feeds)
            {
                feed.post(subreddit);
            }
        }

        private bool parseInput()
        {
            bool result = true;
            if (!Int32.TryParse(intervalTextBox.Text, out interval) || interval <= 0)
            {
                intervalTextBox.BackColor = Color.Red;
                result = false;
            }
            else
            {
                timer.Interval = interval * 1000;
                intervalTextBox.BackColor = Color.White;
            }

            if (usernameTextBox.Text != String.Empty && passwordTextBox.Text != String.Empty)
            {
                try
                {
                    reddit.LogIn(usernameTextBox.Text, passwordTextBox.Text);
                    usernameTextBox.BackColor = Color.White;
                    passwordTextBox.BackColor = Color.White;
                }
                catch
                {
                    usernameTextBox.BackColor = Color.Red;
                    passwordTextBox.BackColor = Color.Red;
                    MessageBox.Show("Login Failed");
                    result = false;
                }
                
            }
            else
            {
                result = false;
            }

            if (!subredditTextBox.Text.StartsWith("/r/"))
            {
                subredditTextBox.Text = "/r/" + subredditTextBox.Text;
            }
            else
            {
                try
                {
                    subreddit = reddit.GetSubreddit(subredditTextBox.Text);
                    subredditTextBox.BackColor = Color.White;
                }
                catch
                {
                    subredditTextBox.BackColor = Color.Red;
                    result = false;
                }
                
            }

            return result;
        }

        private void NSFWCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            NSFW = NSFWCheckBox.Checked;
            subreddit.NSFW = NSFW;
        }
    }
}
