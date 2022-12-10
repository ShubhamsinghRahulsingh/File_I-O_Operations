using File_IO_Operations.FileOperations;
using System;
namespace File_IO_Operations
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileOperation file = new FileOperation();
            Console.WriteLine("Welcome to Perform Operations on File");
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Select From the Following\n1.FileExistsOrNot\n2.ReadAllLines\n3.ReadAllText\n4.CopyFile\n5.Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        file.FileExists();
                        break;
                    case 2:
                        file.ReadAllLines();
                        break;
                    case 3:
                        file.ReadAllText();
                        break;
                    case 4:
                        file.CopyFile();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}