using System;

namespace Linq
{
    public class Student(int id, string name, int age, string department)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Department { get; set; } = department;

        public override string ToString()
        {
            return $"{Id} - {Name}, Age: {Age}, Department: {Department}";
        }
    }
}