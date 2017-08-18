using System;

namespace Craft.Tests
{
    public class Account
    {        
        public DateTime DueDate { get; set; }
        public Customer Customer { get; set; }
        public double Balance { get; set; }
    }    
}