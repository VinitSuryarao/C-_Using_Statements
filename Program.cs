using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Statement set boundary of object which outside that object will automatically destroy.
            using (StreamReader reader = File.OpenText(@"E:\Code\C#\Using_Statement\TempFile.txt"))
            {
                if (reader.EndOfStream)
                    return;
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
