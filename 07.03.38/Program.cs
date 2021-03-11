using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07._03._38
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => MyFileManager.ReadFromFile());
            t1.Start();
            Thread.Sleep(1000);
        }

    }


}
