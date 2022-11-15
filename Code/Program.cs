namespace Chameleon
{

    internal class Program
    {
        static void Main()
        {
            // Makes a new variable for the Aksing class
            Asking asking = new();
            //Makes a new variable for the MakeList class
            MakeList list = new();
            //Makes a new variable for the LoadFile class
            TakeList load = new();
            //Gets the path of the file from User
            list.ListPath();
            //Checks if the file already exists
            //If it does it loads the file into the program
            //if it doesnt it makes a new file
            if (File.Exists(list.path))
            {
                load.LoadFile(list.path);
            }
            else
            {
                list.Write();
                list.ListSaver();
            }
            if (asking.Choosing() == 1)
            {
                asking.MainToForign(load.mainlanguage, load.secondLanguage);
            }
            else
            {
                asking.ForignToMain(load.mainlanguage, load.secondLanguage);
            }
            asking.DisplayPoints();
            
        }
    }
}
