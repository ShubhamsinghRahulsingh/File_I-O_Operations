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
            string[] lines=File.ReadAllLines(filePath);//read line by line
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        //UC3
        public void ReadAllText()
        {
            string lines = File.ReadAllText(filePath);//read all text as a single string
            Console.WriteLine(lines);
        }
        //UC4
        public void CopyFile()
        {
            string CopyPath = @"D:\GitRepository\File_IO_Operations\File_IO_Operations\File\operationNew.txt";
            File.Copy(filePath, CopyPath);
            Console.WriteLine("File is Copied");
        }
        //UC5
        public void DeleteFile()
        {
            string DeleteFile = @"D:\GitRepository\File_IO_Operations\File_IO_Operations\File\operationNew.txt";
            File.Delete(DeleteFile);
            Console.WriteLine("File is Deleted");
        }
    }
}
