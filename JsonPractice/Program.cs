using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonPractice
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Student : Person
    {
        public float GPA { get; set; }
    }

    class Dog
    {
        public string Name { get; set; }

        [JsonPropertyName("Age")]
        public int DogYears { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var student = new Person() { Age = 14, Name = "Sammy", };  // GPA = 3.4f };
            var jsonStudent = JsonSerializer.Serialize(student);
            ;

            File.WriteAllText("person.json", jsonStudent);
            var studentCopy = JsonSerializer.Deserialize<Dog>(jsonStudent);

            ;
        }
    }
}
