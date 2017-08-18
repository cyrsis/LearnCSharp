namespace Demos.DemoSupportCode
{
    class Person
    {
        private readonly string _name;
        private readonly int _age;
        private readonly string _gender;

        private const string DefaultGender = "default";
        
        public Person(string name)
        {
            _name = name;
            _age = int.MinValue;
            _gender = DefaultGender;
        }

        #region 

        //public Person(string name) : this(name, int.MinValue, DefaultGender)
        //{            
        //}

        #endregion


        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            _gender = DefaultGender;
        }

        #region 

        //public Person(string name, int age) : this (name, age, DefaultGender)
        //{
        //}

        #endregion


        public Person(string name, int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }
    }
}
