using System;
using System.IO;
using System.Threading;

namespace Chameleon
{

    internal class Program
    {
        static void Main()
        {
            //Makes a new variable for the MakeList class
            MakeList list = new();
            //Gets the path of the file from User
            list.ListPath();
            //Checks if the file already exists
            if (File.Exists(list.path))
            {
                //Load LoadingFile class
            }
            else
            {
                list.Write();
                list.ListSaver();
            }

            
        }
    }
}