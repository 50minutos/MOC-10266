using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _003_DriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in DriveInfo.GetDrives())
            {
                Console.WriteLine("{0} -> {1}", item.Name, item.IsReady);
            }

            Console.ReadKey();
        }
    }
}
