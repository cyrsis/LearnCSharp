using System;

namespace CS61
{
    public class User(string userName)
    {
       public Guid Id { get; } = Guid.NewGuid();
       public string Username { get; protected set; } = userName;
    }
}
