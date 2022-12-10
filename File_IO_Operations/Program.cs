using File_IO_Operations.FileOperations;
using File_IO_Operations.SerializationAndDeserialization;
using System;
namespace File_IO_Operations
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileOperation file = new FileOperation();
            Binary binary = new Binary();
            JSon jSon = new JSon();
            Console.WriteLine("Welcome to Perform Operations on File");
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Select From the Following\n1.FileExistsOrNot\n2.ReadAllLines\n3.ReadAllText\n4.CopyFile\n5.DeleteFile\n6.ReadFromStreamReader\n7.WriteFromStreamWriter\n8.BinarySerialization\n9.BinaryDeserialization\n10.JsonSerializaion\n11.JsonDeSerialization\n12.Exit");
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
                        file.DeleteFile();
                        break;
                    case 6:
                        file.ReadFromStreamReader();
                        break;
                    case 7:
                        file.WriteFromStreamWriter();
                        break;
                    case 8:
                        binary.Binaryserialization();
                        break;
                    case 9:
                        binary.BinaryDeserialization();
                        break;
                    case 10:
                        jSon.JsonSerialize();
                        break;
                    case 11:
                        jSon.JsonDeSerialize();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }
        }
    }
}