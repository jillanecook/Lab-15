using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class CountriesTextFile
    {
        public void ListCountries()
        {
            Console.WriteLine("Please select an option: (1), (2), or (3)");
            string input = (Console.ReadLine());

            string filePath = @"C:\Users\cookj\Desktop\Countries.txt";



            StreamReader reader = new StreamReader(filePath);

            if (input == "1")
            {

                string line = reader.ReadToEnd();
                input = reader.ReadToEnd();
                Console.WriteLine(input);
                Console.WriteLine(line);
            } // do I need an exception here?

        }

        //public void WriteCountries()
        //{
        //    Console.WriteLine("Please select an option: (1), (2), or (3)");
        //    string input = (Console.ReadLine());

        //    StreamWriter writer;

        //    string filePath = @"C:\Users\cookj\Desktop\Countries.txt";

        //    if (input == "2")
        //    {
        //        writer = new StreamWriter(filePath);
        //        writer.Write("ITALY ");
        //        writer.WriteLine("SPAIN");
        //        writer.WriteLine("ENGLAND");
        //        writer.Close();

        //    }
        }
    }
}


