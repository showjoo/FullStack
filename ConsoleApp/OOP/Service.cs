using System;
namespace OOP
{
    public interface ICourseService
    {
        bool AddStudent(Student s);
        bool RemoveStudent(Student s);
    }
    public interface IPersonService
    {
        bool ChangePhone(string phone);
    }
    public interface IStudentService : IPersonService
    {
        bool DropClass(Course c);
    }
    public interface IInstructorService : IPersonService
    {
        bool InstructClass(Course c);
    }
}

