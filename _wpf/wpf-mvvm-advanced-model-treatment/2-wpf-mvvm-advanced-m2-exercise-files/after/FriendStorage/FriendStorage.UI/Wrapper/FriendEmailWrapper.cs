using FriendStorage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendStorage.UI.Wrapper
{
  public class FriendEmailWrapper : ModelWrapper<FriendEmail>
  {
    public FriendEmailWrapper(FriendEmail model) : base(model)
    {
    }

    public int Id
    {
      get { return GetValue<int>(); }
      set { SetValue(value); }
    }

    public string Email
    {
      get { return GetValue<string>(); }
      set { SetValue(value); }
    }

    public string Comment
    {
      get { return GetValue<string>(); }
      set { SetValue(value); }
    }
  }
}
