namespace CS61
{
    public static class UserStorageExtensions
    {
         public static User Add(this UserStorage store, User newUser)
        {
            store.Insert(newUser);
            return newUser;
        }
    }
}
