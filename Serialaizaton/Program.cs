using System;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Mohammed Abu-Hadhoud", Age = 46 };
        // XML Code
        /*
        // XML serialization
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (TextWriter writer = new StreamWriter("person.xml"))
        {
            serializer.Serialize(writer, person);
        }


        // Deserialize the object back
        using (TextReader reader = new StreamReader("person.xml"))
        {
            Person deserializedPerson = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
        */

        // Json Code
        /*
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
        using (MemoryStream stream = new MemoryStream())
        {
            serializer.WriteObject(stream, person);
            string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());


            // Save the JSON string to a file (optional)
            File.WriteAllText("person.json", jsonString);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.json", FileMode.Open))
        {
            Person deserializedPerson = (Person)serializer.ReadObject(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }

        */

        // Binary Code
        /*
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadKey();
        }
        */


    }
}