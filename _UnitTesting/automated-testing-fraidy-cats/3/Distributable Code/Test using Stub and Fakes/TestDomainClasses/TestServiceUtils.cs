using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceUtilities;
namespace TestDomainClasses
{
  [TestClass]
  public class ExternalServiceTests
  {
    //I didn't use this in the course. I only used this in my own
    //testing while building the samples to make sure that my twitter
    //method truly worked even though I never ran that method either. :)
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
