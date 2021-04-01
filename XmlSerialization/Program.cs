using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization {
    class Program {
        static void Main (string[] args) {
            Student student = new Student ("Иван", 12);

            XmlSerializer ser = new XmlSerializer (typeof (Student));
            using (FileStream stream = File.Create ("student.xml"))
                ser.Serialize (stream, student);

            using (FileStream stream = File.OpenRead ("student.xml"))
                student = (Student) ser.Deserialize (stream);

            Console.WriteLine ($"{student.Name} {student.Grade}");
        }
    }
}
