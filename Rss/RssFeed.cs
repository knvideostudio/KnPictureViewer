using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

namespace KnPictureViewer.Rss
{


    public class RssFeed
    {
        private List<RssChannel> channels;
        public IList<RssChannel> Channels { get { return channels.AsReadOnly(); } }
        public RssChannel MainChannel { get { return Channels[0]; } }

        private RssFeed(XmlNode xmlNode)
        {
            channels = new List<RssChannel>();

            XmlNode rssNode = xmlNode.SelectSingleNode("rss");

            XmlNodeList channelNodes = rssNode.ChildNodes;
            foreach (XmlNode channelNode in channelNodes)
            {
                RssChannel newChannel = new RssChannel(channelNode);
                channels.Add(newChannel);
            }
        }


        public static RssFeed FromUri(string uri)
        {
            XmlDocument xmlDoc;
            WebClient webClient = new WebClient();
            using (Stream rssStream = webClient.OpenRead(uri))
            {
                TextReader textReader = new StreamReader(rssStream);
                XmlTextReader reader = new XmlTextReader(textReader);
                xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
            }
            return new RssFeed(xmlDoc);
        }

        public static RssFeed FromText(string rssText)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(rssText);
            return new RssFeed(xmlDoc);
        }
    }
}
