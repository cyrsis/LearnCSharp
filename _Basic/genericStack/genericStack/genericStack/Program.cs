using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<UserAction> userActions = new Stack<UserAction>();

            {
                UserAction userAction = new UserAction
                {
                    Description = "created report",
                    Abbreviation = "cre_rep",
                    ObjectId = 34
                };
                userActions.Push(userAction);
            }

            {
                UserAction userAction = new UserAction
                {
                    Description = "added graph to report",
                    Abbreviation = "add_gra",
                    ObjectId = 11
                };
                userActions.Push(userAction);
            }

            {
                UserAction userAction = new UserAction
                {
                    Description = "deleted report",
                    Abbreviation = "del_rep",
                    ObjectId = 34
                };
                userActions.Push(userAction);
            }

            Console.WriteLine("user action history:");
            foreach (var userAction in userActions)
                Console.WriteLine("- " + userAction.ShowIt());

            Console.WriteLine("last action was:");
            Console.WriteLine(userActions.Peek().ShowIt());

            UserAction undoneUserAction = userActions.Pop();
            Console.WriteLine("this action was undone: " + undoneUserAction.ShowIt());

            Console.WriteLine("user action history:");
            foreach (var userAction in userActions)
                Console.WriteLine("- " + userAction.ShowIt());

            Console.ReadLine();
        }
    }

    public class UserAction
    {
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public int ObjectId { get; set; }

        internal string ShowIt()
        {
            return String.Format("{0} ({1}) affecting object {2}", Description, Abbreviation, ObjectId);
        }
    }

}
