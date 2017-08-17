using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ServiceUtilities
{
  public interface ITwitterDataUtilities
  {
    DateTime LatestTweetDateAsUtc(string twitterAlias);
  }



  public class TwitterDataUtilities : ITwitterDataUtilities
  {
    public DateTime LatestTweetDateAsUtc(string twitterAlias)
    {
      var uri = new Uri("https://api.twitter.com/1/statuses/user_timeline/" + twitterAlias + ".json?count=1");
      var client = new WebClient();
      var result = client.DownloadString(uri);
      var jsonString = result.Replace("[", "").Replace("]", "");
      var o = JObject.Parse(jsonString);
      const string constTwitterDateTemplate = "ddd MMM dd HH:mm:ss +ffff yyyy";
      DateTime createdAt = DateTime.ParseExact((string)o["created_at"], constTwitterDateTemplate, new System.Globalization.CultureInfo("en-US"));
      return createdAt;
    }
  }
}
