using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceUtilities;
namespace TestDomainClasses
{
  [TestClass]
  public class ExternalServiceTests
  {
    [TestMethod]
    public void LatestTweetDateReturnsADateFromTwitter()
    {
      var twitterUtils = new TwitterDataUtilities();
      var jsonResult=twitterUtils.LatestTweetDateAsUtc("julielerman");
      Debug.WriteLine(jsonResult);
      Assert.IsTrue(jsonResult> DateTime.MinValue);
    }
  }
}
