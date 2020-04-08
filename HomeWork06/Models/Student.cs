using System;

namespace Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public int Group { get; set; }

        public Student(string name,string academy,int group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public string StudentInfo()
        {
            return $"The student {Name} study at the academy {Academy} in group {Group}";
        }
    }
}
