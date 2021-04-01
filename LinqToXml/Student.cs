using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml {
    class Student {
        public string Name { get; }
        public int Grade { get; }

        public Student (string name, int grade) {
            Name = name;
            Grade = grade;
        }

        public XElement ToXElement () => new XElement ("student",
            new XElement ("name", this.Name),
            new XElement ("grade", this.Grade));
    }
}
