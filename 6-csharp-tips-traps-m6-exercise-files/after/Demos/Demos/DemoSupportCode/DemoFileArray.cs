namespace Demos.DemoSupportCode
{
    // For full implementation including actual file IO see MSDN: http://bit.ly/pscsindexer
    public class DemoFileArray
    {    
        public DemoFileArray(string filePath)
        {
            // create a file stream object from this filePath
        }

       
        public byte this[long index]
        {            
            get
            {
                // move to the position in the stream (without reading whole file into memory)
                // and return the byte value in the file at that position specified in index

                return 42; // dummy value for demo purposes
            }            
            set
            {
                byte valueToWriteToFile = value;

                // move to the position in the stream (without reading whole file into memory)
                // and set the byte value in the file at that position to "value"
            }
        }
    }
}