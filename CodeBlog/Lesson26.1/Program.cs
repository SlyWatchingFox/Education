﻿using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Lesson26._1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();
            for (int i = 1; i < 10; i++)
            {
                groups.Add(new Group(i, "Группа " + i));
            }
            for (int i = 0; i < 300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9],
                };
                students.Add(student);
            }



            //
            //binFormatter
            //
            //var binFormatter = new BinaryFormatter();
            //using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            //{
            //    binFormatter.Serialize(file, groups);
            //}
            //using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            //{
            //    var newGroups = binFormatter.Deserialize(file) as List<Group>;
            //    if (newGroups != null)
            //    {
            //        foreach (var group in newGroups)
            //        {
            //            Console.WriteLine(group);
            //        }
            //    }
            //}

            //
            //XMLFormater
            //
            //var xmlFormatter = new XmlSerializer(typeof(List<Group>));
            //using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            //{
            //    xmlFormatter.Serialize(file, groups);
            //}
            //using (var file = new FileStream("groups.xml", FileMode.OpenOrCreate))
            //{
            //    var newGroups = xmlFormatter.Deserialize(file) as List<Group>;
            //    if (newGroups != null)
            //    {
            //        foreach (var group in newGroups)
            //        {
            //            Console.WriteLine(group);
            //        }
            //    }
            //}
            //
            //JSONFormater
            //

            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
            using (var file = new FileStream("students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, students);
            }
        }
    }
}