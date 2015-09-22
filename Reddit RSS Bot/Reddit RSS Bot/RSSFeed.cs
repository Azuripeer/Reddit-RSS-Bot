using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using RedditSharp;
using RedditSharp.Things;

namespace Reddit_RSS_Bot
{
    class RSSFeed
    {
        private string URL;
        private SyndicationItem lastPost;                      //The lastPost is the last post the RSSfeed contains. This is used to determine which posts to post.
        private XmlReader reader;

        public RSSFeed(string URL)
        {
            this.URL = URL;
            updateLastPost();
        }

        public string getURL()
        {
            return URL;
        }

        public void post(Subreddit subreddit)
        {
            reader = XmlReader.Create(URL);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                if(item.Title.Text == lastPost.Title.Text)
                {
                    break;
                }
                else
                {
                    try
                    {
                        postItem(item, subreddit);
                    }
                    catch (Exception) { }
                }
            }
        }

        private void updateLastPost()
        {
            reader = XmlReader.Create(URL);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            lastPost = feed.Items.First();
            
        }

        private void postItem(SyndicationItem item, Subreddit subreddit)
        {
              subreddit.SubmitPost(item.Title.Text, item.Links.ElementAt(0).Uri.OriginalString);
        }
    }
}
