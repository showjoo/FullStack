using System;
namespace OOP
{
	public abstract class Person
	{
		public int ID { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
		public DateTime Birthday { get; set; }

		public Person(int id, string name, DateTime birthday)
		{
			ID = id;
            Name = name;
            Birthday = birthday;
		}
        public int CalculateAge()
        {
            var today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today.Month < Birthday.Month || (today.Month == Birthday.Month && today.Day < Birthday.Day))
                age--;
            return age;
        }
        public virtual decimal CalculateSalary()
        {
            decimal res = 0.0M;
            Console.WriteLine($"This Person's Salary is {res}");
            return res;
        }
	}

	public class Student : Person,IStudentService
	{
        public List<Course> Courses { get; set; }
        public List<char> Grades { get; set; }
        public Student(int id, string name, DateTime birthday) : base(id, name, birthday)
        {
            Courses = new List<Course>();
            Grades = new List<char>();
        }
        public override decimal CalculateSalary()
        {
            decimal res = 0.0M;
            Console.WriteLine("A student has no salary!");
            return res;
        }
        public double CalculateGPA()
        {
            double GPA = 0.0;
            foreach (char grade in Grades)
            {
                switch (grade)
                {
                    case 'A':
                        GPA += 4.0;
                        break;
                    case 'B':
                        GPA += 3.5;
                        break;
                    case 'C':
                        GPA += 3.0;
                        break;
                    case 'D':
                        GPA += 2.0;
                        break;
                    case 'E':
                        GPA += 1.0;
                        break;
                    default:
                        GPA += 0.0;
                        break;
                }
            }
            double res = GPA / Grades.Count();
            return res;
        }

        public bool DropClass(Course c)
        {
            if (Courses.Contains(c))
            {
                Courses.Remove(c);
                return true;
            }
            return false;
        }

        public bool ChangePhone(string phone)
        {
            Phone = phone;
            return true;
        }
    }

	public class Instructor : Person
    {
        public Department Department { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal MonthlyPay { get; set; }
        public decimal Bonus { get; set; }

        public Instructor(int id, string name, DateTime birthday, Department department, decimal monthlyPay) : base(id, name, birthday)
        {
            Department = department;
            MonthlyPay = monthlyPay;
        }
        public override decimal CalculateSalary()
        {
            decimal res = MonthlyPay * 12 + CalculateJoinAge() * Bonus;
            Console.WriteLine($"This Person's Salary is {res}");
            return res;
        }
        public int CalculateJoinAge()
        {
            var today = DateTime.Today;
            int age = today.Year - JoinDate.Year;
            if (today.Month < JoinDate.Month || (today.Month == JoinDate.Month && today.Day < JoinDate.Day))
                age--;
            return age;
        }

    }
}

