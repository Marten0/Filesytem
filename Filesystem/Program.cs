using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filesystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootPath = @"C:\users\opilane\source\repos\logitpe21\filesystem";

            //string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //   Console.WriteLine(dir);
            //}

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    // Console.WriteLine(file);
            //    //Console.WriteLine(Path.GetFileName(file));
            //    //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    //Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}: bytes");
            //}

            string newPath = (@"\user\opilane\source\repos\logitpe21\filesystem\subfolderC");

            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                Console.WriteLine("the directory exists");
            }
            else
            {
                Console.WriteLine("the directoy does not exists");
                Directory.CreateDirectory(newPath);
            }

            Console.ReadLine();
        }
    }
}
