using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml {
    class Program {
        static void Main (string[] args) {
            Student student = new Student ("Иван", 12);

            XElement document = student.ToXElement ();

            Console.WriteLine (document);

            document.Save ("student.xml");
        }
    }
}
