using Microsoft.Office.Interop.Word;

namespace Lib1
{
    public class Stuff
    {
        public static Application NewWord()
        {
            var app = new Application();
            app.Visible = true;
            return app;
        }

        public static void QuitWord(Application app)
        {
            app.Quit(SaveChanges: false);
        }
    }
}
