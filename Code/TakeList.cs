using System.Text;
using System.Threading;

namespace Chameleon
{
    class TakeList
    {
        //Makes List for the 2 Languages needed
        public List<string> mainlanguage = new List<string>();
        public List<string> secondLanguage = new List<string>();

        public void LoadFile(string path)
        {
            //Saves everything in the file from (path) in text
            string text = File.ReadAllText(path);
            //
            string[] lines = text.Split("\r\n");
            int words = lines.Length;

            //Splits the contents of the files with "," into main- and secondlanguage 
            for (int i = 0; i < lines.Length; i++)
            {
                string[] items = lines[i].Split(",");
                mainlanguage.Add(items[0]);
                secondLanguage.Add(items[1]);
            }
        }
    }
}