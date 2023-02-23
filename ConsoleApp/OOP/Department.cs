using System;
namespace OOP
{
	public class Department
	{
        public int ID { get; set; }
        public string Name { get; set; }
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; }

        public Department(int id, string name)
        {
            ID = id;
            Name = name;
            Courses = new List<Course>();
        }
    }
}

