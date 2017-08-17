using FriendStorage.Model;
using FriendStorage.UI.Wrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendStorage.UITests.Wrapper
{
  [TestClass]
  public class ChangeTrackingCollectionProperty
  {
    private Friend _friend;

    [TestInitialize]
    public void Initialize()
    {
      _friend = new Friend
      {
        FirstName = "Thomas",
        Address = new Address(),
        Emails = new List<FriendEmail>
        {
          new FriendEmail { Email="thomas@thomasclaudiushuber.com" },
          new FriendEmail {Email="julia@juhu-design.com" }
        }
      };
    }

    [TestMethod]
    public void ShouldSetIsChangedOfFriendWrapper()
    {
      var wrapper = new FriendWrapper(_friend);
      var emailToModify = wrapper.Emails.First();
      emailToModify.Email = "modified@thomasclaudiushuber.com";

      Assert.IsTrue(wrapper.IsChanged);

      emailToModify.Email = "thomas@thomasclaudiushuber.com";
      Assert.IsFalse(wrapper.IsChanged);
    }

    [TestMethod]
    public void ShouldRaisePropertyChangedEventForIsChangedPropertyOfFriendWrapper()
    {
      var fired = false;
      var wrapper = new FriendWrapper(_friend);
      wrapper.PropertyChanged += (s, e) =>
        {
          if (e.PropertyName == nameof(wrapper.IsChanged))
          {
            fired = true;
          }
        };

      wrapper.Emails.First().Email = "modified@thomasclaudiushuber.com";
      Assert.IsTrue(fired);
    }

    [TestMethod]
    public void ShouldAcceptChanges()
    {
      var wrapper = new FriendWrapper(_friend);

      var emailToModify = wrapper.Emails.First();
      emailToModify.Email = "modified@thomasclaudiushuber.com";

      Assert.IsTrue(wrapper.IsChanged);

      wrapper.AcceptChanges();

      Assert.IsFalse(wrapper.IsChanged);
      Assert.AreEqual("modified@thomasclaudiushuber.com", emailToModify.Email);
      Assert.AreEqual("modified@thomasclaudiushuber.com", emailToModify.EmailOriginalValue);
    }

    [TestMethod]
    public void ShouldRejectChanges()
    {
      var wrapper = new FriendWrapper(_friend);

      var emailToModify = wrapper.Emails.First();
      emailToModify.Email = "modified@thomasclaudiushuber.com";

      Assert.IsTrue(wrapper.IsChanged);

      wrapper.RejectChanges();

      Assert.IsFalse(wrapper.IsChanged);
      Assert.AreEqual("thomas@thomasclaudiushuber.com", emailToModify.Email);
      Assert.AreEqual("thomas@thomasclaudiushuber.com", emailToModify.EmailOriginalValue);
    }
  }
}
