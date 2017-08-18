namespace Demos.DemoSupportCode
{    
    public class Student
    {
        private int[] _examScores = {56, 22, 99, 25};

       
        public int this[int index]
        {            
            get { return _examScores[index]; }            
            set { _examScores[index] = value; }
        }
    }
}