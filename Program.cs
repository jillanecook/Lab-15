using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    namespace FileIO
        {
    class Program
    {

        static void Main(string[] args)
        {
            CountriesTextFile list = new CountriesTextFile();
            list.ListCountries();

            //CountriesTextFile write = new CountriesTextFile();
            //write.WriteCountries();    //when I run this code, the write countries overwrites the list of countries 
            //from List Countries




        }
    }
        
}
