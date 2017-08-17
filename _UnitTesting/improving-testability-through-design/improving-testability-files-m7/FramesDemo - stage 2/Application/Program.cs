using System;

namespace Demo
{

    class BusinessLayer
    {

        private readonly DataGateway gateway;

        public BusinessLayer(DataGateway gateway)
        {
            this.gateway = gateway;
        }

        public Model DoSomething(int key)
        {
            return this.gateway.FetchData(key).DoSomething();
        }

    }

    class DataGateway
    {

        private readonly DataAccessLayer dal;

        public DataGateway(DataAccessLayer dal)
        {
            this.dal = dal;
        }

        public Model FetchData(int key)
        {
            Dto dto = this.dal.FetchData(key);
            return new Model(dto.SomeValue.Length + dto.SomeData.Length);
        }

    }

    class Model
    {

        private readonly int key;

        public Model(int key)
        {
            this.key = key;
        }

        public Model DoSomething()
        {
            return new Model(this.key + 1);
        }

        public override string ToString()
        {
            return string.Format("Brand new model #{0}", this.key);
        }

    }

    class DataAccessLayer
    {
        public Dto FetchData(int key)
        {
            return new Dto()
            {
                SomeValue = "something",
                SomeData = new byte[key]
            };
        }
    }

    class Dto
    {
        public string SomeValue { get; set; }
        public byte[] SomeData { get; set; }
    }

    static class Application
    {
        public static void Run()
        {

            BusinessLayer business =
                new BusinessLayer(
                    new DataGateway(
                        new DataAccessLayer()));

            Model model = business.DoSomething(4);
            Console.WriteLine(model);
            Console.ReadLine();

        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Application.Run();
        }
    }
}
