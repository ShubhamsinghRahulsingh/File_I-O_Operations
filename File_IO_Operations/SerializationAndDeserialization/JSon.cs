using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Operations.SerializationAndDeserialization
{
    public class JSon
    {
        public void JsonSerialize()
        {
            BlogSites bsObject = new BlogSites()
            {
                Name = "Shubham",
                Description = "Welcome to the coding"
            };
            //converting Blogsites object to json string format
            string jsonData = JsonConvert.SerializeObject(bsObject);
            Console.WriteLine(jsonData);
        }
        public void JsonDeSerialize()
        {
            string json = @"{
            
                'Name':'Shubham',
                'Description':'Welcome to the coding'
            }";
            //converting json string format to Blogsites object
            BlogSites bsObject = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine("Name:"+bsObject.Name+"\n"+"Description:"+ bsObject.Description);
        }

    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
