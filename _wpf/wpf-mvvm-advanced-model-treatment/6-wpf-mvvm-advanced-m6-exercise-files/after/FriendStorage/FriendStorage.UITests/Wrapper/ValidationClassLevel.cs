using FriendStorage.Model;
using FriendStorage.UI.Wrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FriendStorage.UITests.Wrapper
{
  [TestClass]
  public class ValidationClassLevel
  {
    private Friend _friend;

    [TestInitialize]
    public void Initialize()
    {
      _friend = new Friend
      {
        FirstName = "Thomas",
        Address = new Address { City = "Müllheim" },
        Emails = new List<FriendEmail>
        {
          new FriendEmail { Email="thomas@thomasclaudiushuber.com" },
          new FriendEmail {Email="julia@juhu-design.com" }
        }
      };
    }

    [TestMethod]
    public void ShouldHaveErrorsAndNotBeValidWhenIsDeveloperIsTrueAndNoEmailExists()
    {
      var expectedError = "A developer must have an email-address";

      var wrapper = new FriendWrapper(_friend);
      wrapper.Emails.Clear();
      Assert.IsFalse(wrapper.IsDeveloper);
      Assert.IsTrue(wrapper.IsValid);

      wrapper.IsDeveloper = true;
      Assert.IsFalse(wrapper.IsValid);

      var emailsErrors = wrapper.GetErrors(nameof(wrapper.Emails)).Cast<string>().ToList();
      Assert.AreEqual(1, emailsErrors.Count);
      Assert.AreEqual(expectedError, emailsErrors.Single());

      var isDeveloperErrors = wrapper.GetErrors(nameof(wrapper.IsDeveloper)).Cast<string>().ToList();
      Assert.AreEqual(1, isDeveloperErrors.Count);
      Assert.AreEqual(expectedError, isDeveloperErrors.Single());
    }

    [TestMethod]
    public void ShouldBeValidAgainWhenIsDeveloperIsSetBackToFalse()
    {
      var wrapper = new FriendWrapper(_friend);
      wrapper.Emails.Clear();
      Assert.IsFalse(wrapper.IsDeveloper);
      Assert.IsTrue(wrapper.IsValid);

      wrapper.IsDeveloper = true;
      Assert.IsFalse(wrapper.IsValid);


      wrapper.IsDeveloper = false;
      Assert.IsTrue(wrapper.IsValid);

      var emailsErrors = wrapper.GetErrors(nameof(wrapper.Emails)).Cast<string>().ToList();
      Assert.AreEqual(0, emailsErrors.Count);

      var isDeveloperErrors = wrapper.GetErrors(nameof(wrapper.IsDeveloper)).Cast<string>().ToList();
      Assert.AreEqual(0, isDeveloperErrors.Count);
    }

    [TestMethod]
    public void ShouldBeValidAgainWhenEmailIsAdded()
    {
      var wrapper = new FriendWrapper(_friend);
      wrapper.Emails.Clear();
      Assert.IsFalse(wrapper.IsDeveloper);
      Assert.IsTrue(wrapper.IsValid);

      wrapper.IsDeveloper = true;
      Assert.IsFalse(wrapper.IsValid);

      wrapper.Emails.Add(new FriendEmailWrapper(new FriendEmail { Email = "thomas@thomasclaudiushuber.com" }));
      Assert.IsTrue(wrapper.IsValid);

      var emailsErrors = wrapper.GetErrors(nameof(wrapper.Emails)).Cast<string>().ToList();
      Assert.AreEqual(0, emailsErrors.Count);

      var isDeveloperErrors = wrapper.GetErrors(nameof(wrapper.IsDeveloper)).Cast<string>().ToList();
      Assert.AreEqual(0, isDeveloperErrors.Count);
    }

    [TestMethod]
    public void ShouldIntializeWithoutProblems()
    {
      _friend.IsDeveloper = true;
      var wrapper = new FriendWrapper(_friend);
      Assert.IsTrue(wrapper.IsValid);
    }
  }
}
