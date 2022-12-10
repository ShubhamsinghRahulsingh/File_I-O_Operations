using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Operations.FileOperations
{
    public class FileOperation
    {
        string filePath = @"D:\GitRepository\File_IO_Operations\File_IO_Operations\File\operation.txt";
        //UC1
        public void FileExists()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("Given File Exists");
            }
            else
                Console.WriteLine("File Does not Exists");
        }//UC2
        public void ReadAllLines()
        {
            string[] lines=File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
