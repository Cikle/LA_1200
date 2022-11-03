namespace Chameleon
{
    class MakeList
    {
        //String for the Storagepath of the file
        //String for the words, which will be inserted in the new .csv file
        public string path = @"";
        public string words = "";
        
        //This method is here to write a new .csv file, if there is no existing .csv file
        public string Write()
        {
            while (true)
            {
                //This is to name the new .csv document
                string fileName = "";
                try
                {
                    Console.Clear();
                    Console.Write("Give your File a name: ");
                    fileName = Console.ReadLine();
                    //This is to check if this file already exists
                    if (File.Exists(path + @"\" + fileName + ".csv"))
                    {
                        throw new Exception();
                    }
                    path += @"\" + fileName + ".csv";
                    break;
                }
                catch
                {
                    Console.WriteLine("This file already exists.");
                    Thread.Sleep(1500);
                }
            }

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
            bool loop0 = false;
            while (loop0 == false)
            {
                Console.Clear();
                //get the file / folder location
                try
                {
                    Console.Write("Storagefolder: ");
                    path += Console.ReadLine();
                    //if you already have the right file in the entered path
                    if (File.Exists(path))
                    {
                        return path;
                    }
                    //if the directory which is in the path even exists
                    if (!Directory.Exists(path))
                    {
                        path = @"";
                        throw new Exception();
                    }

                    List<string> files = new List<string>();
                    bool loop1 = false;
                    while (loop1 == false)
                    {
                        try
                        {
                            Console.Clear();
                            string answer;
                            int i = 0;
                            files.Clear();
                            //Show all .csv files in the directory
                            foreach (var file in Directory.GetFiles(path, "*.csv").Select(Path.GetFileName))
                            {
                                files.Add(file);
                                Console.WriteLine($"{i + 1}: {files[i]}");
                                i++;
                            }
                            //choose which file you want to load
                            Console.WriteLine($"Type the Filenumber 1 - {files.Count}\n" +
                                              $"If you want to create a new file type [new]");
                            answer = Console.ReadLine();
                            //if you want to make a new file
                            if (answer == "new")
                            {
                                loop0 = true;
                                break;
                            }
                            else if (Convert.ToInt32(answer) <= files.Count() && Convert.ToInt32(answer) > 0)
                            {
                                loop0 = true;
                                path += @"\" + files[Convert.ToInt32(answer) - 1];
                                break;
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"Please type a number between 1 and {files.Count()} or new.");
                            Thread.Sleep(2000);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Please writedown an existing directory Path");
                    Thread.Sleep(2000);
                }
            }
            return path;
        }
        //This method is here to save the new written file
        public void ListSaver()
        {
            File.WriteAllText(path, words);
        }
    }
}