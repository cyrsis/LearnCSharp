namespace Accountant.Api.Models
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string Email { get; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}