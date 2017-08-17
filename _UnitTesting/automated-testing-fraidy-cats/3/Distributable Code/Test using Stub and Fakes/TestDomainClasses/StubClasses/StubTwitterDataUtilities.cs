using System;
using ServiceUtilities;

namespace TestDomainClasses.StubClasses
{
  public class StubTwitterDataUtilities : ITwitterDataUtilities
  {
    public DateTime LatestTweetDateAsUtc(string twitterAlias)
    {
      return new DateTime(2010, 1, 1);
    }
  }
}
