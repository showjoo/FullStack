using System;
namespace OOP
{
	public class Course
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public List<Student> Enrollment { get; set; }

		public Course(int id, string name)
		{
			ID = id;
			Name = name;
			Enrollment = new List<Student>();
		}
	}
}

