namespace Chameleon
{
    class MakeList
    {
        //String for the Storagepath of the file
        //String for the words, which will be inserted in the new .csv file
        public string path = "";
        public string words = "";
        
        //This method is here to write a new .csv file, if there is no existing .csv file
        public string Write()
        {
            while (true)
            {
                //Return if user made a mistake
                ret:

                
                Console.Clear();
                string temp = "";
                string transTemp = "";
                
                //Get words and translations
                Console.WriteLine("If you want to stop type [stp]\n" +
                                  "If you made a mistake type [ret]");
                Console.Write("Word: ");
                temp = Console.ReadLine();
                //Check if user wants to stop or made a mistake
                if (temp == "stp")
                {
                    break;
                }
                if (temp == "ret")
                {
                    goto ret;
                }

                Console.Write("Translation: ");
                transTemp = Console.ReadLine();
                if (transTemp == "ret")
                {
                    goto ret;
                }
                //Put the inputs of the user into one string
                words += $"{temp},{transTemp}\r\n";
                
            }
            return words;
        }
        //This method is here to get the file location of the .csv file
        public string ListPath()
        {
            Console.Write("Storagepath: ");
            path = Console.ReadLine();

            return path;
        }
        //This method is here to save the new written file
        public void ListSaver()
        {
            File.WriteAllText(path, words);
        }
    }
}