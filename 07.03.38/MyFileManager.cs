using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07._03._38
{
    public class MyFileManager
    {
        public const string FILE_PATH = @"c:\final.txt";

        private MyFileManager()
        {

        }

        public async static void ReadFromFile()
        {
            await Task.Run(() =>
            {
                string mytext = File.ReadAllText(@"c:\final.txt");
                Console.WriteLine(mytext);
            });
            
        }
    }
}
