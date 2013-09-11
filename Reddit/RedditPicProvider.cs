using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Reddit
{
    public class RedditPicProvider
    {
        public AwwPic GetAwwPicture()
        {
            var json = new WebClient().DownloadString("http://www.reddit.com/r/aww/top.json?limit=10");
            
            var deserializedObject = JObject.Parse(json);

            var pictures = from x in deserializedObject["data"]["children"]
                let data = x["data"]
                select new AwwPic((string) data["title"], (string) data["url"]);

            return pictures.ElementAt(new Random().Next(0, pictures.Count()));
        }
    }
}
