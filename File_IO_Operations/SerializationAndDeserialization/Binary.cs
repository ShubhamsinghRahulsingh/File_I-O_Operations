using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Operations.SerializationAndDeserialization
{
    public class Binary
    {
        string filePath = @"D:\GitRepository\File_IO_Operations\File_IO_Operations\File\operation.txt";
        public void Binaryserialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"D:\GitRepository\File_IO_Operations\File_IO_Operations\File\Demo.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }
        public void BinaryDeserialization()
        {
            FileStream fileStream = new FileStream(@"D:\GitRepository\File_IO_Operations\File_IO_Operations\File\Demo.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampledemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {deserializedSampledemo.ApplicationName}-----ApplicationId  {deserializedSampledemo.ApplicationId}");
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}
