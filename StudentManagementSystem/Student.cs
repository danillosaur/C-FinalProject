namespace StudentManagementSystem
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student() { }

        public Student(string id, string name, int age, string course)
        {
            StudentID = id;
            Name = name;
            Age = age;
            Course = course;
        }
    }
}