using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleAppPlayground.Interview
{
    public class DouQuestions
    {
        // 1. 


        // 2. 


        // 3. 


        // 4. 


        // 5. 


        // 6. 


        // 7. 


        // 8. 


        // 9. 


        // 10. 


        // 11. 


        // 12. 


        // 13. 


        // 14. 


        // 15. 


        // 16. 







        // 57. SERIALIZATION PROTOCOLS
        // Data contract serialization -> DataContractAttribute -> general, web, json
        // XML serialization -> XmlSerializer -> Xml format
        // Runtime serialization (binary or soap) -> SerializableAttribute -> .net remoting
        // data contract serialization if instances of your type might need to be persisted or used in Web Services
        // XML serialization instead of or in addition to data contract serialization if you need more control over 
        // the XML format that is produced when the type is serialized
        // runtime serialization if instances of your type need to travel across .NET Remoting boundaries
        [DataContract]
        public class Person 
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public int Age { get; set; }
        }


        // 58. CLEAN FUNCTIONS
        // Does not contain any side calculations or operations (call to db, write-read etc), depends only on
        // parameters it has (call of func in another context gives the same outcome)
        // returns only one value, has no state.
        // With c.f. you can use compositions, have less bugs, better multithreading (work with time dependencies)


        // 59. 

    }
}
