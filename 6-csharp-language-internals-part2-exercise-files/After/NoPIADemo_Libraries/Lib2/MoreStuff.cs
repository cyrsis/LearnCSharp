using Microsoft.Office.Interop.Word;

namespace Lib2
{
    public static class MoreStuff
    {
        public static void NewDocument(Application word)
        {
            var doc = word.Documents.Add();
            var par = doc.Paragraphs.Add();
            par.Range.Text = "Hello from C#";
        }
    }
}
