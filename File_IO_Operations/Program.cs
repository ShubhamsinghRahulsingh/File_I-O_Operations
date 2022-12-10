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
                Console.WriteLine("Select From the Following\n1.FileExistsOrNot\n2.Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        file.FileExists();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}