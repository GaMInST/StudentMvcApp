// Data/MockStudentData.cs
using System.Collections.Generic;
using System.Linq;
using StudentMvcApp.Models;

namespace StudentMvcApp.Data
{
    public class MockStudentData
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "OMAR SAYED", Img = "", Address = "maadi" },
            new Student { Id = 2, Name = "MOHSEN KAHLED", Img = "", Address = "october" },
            new Student { Id = 3, Name = "ZYAD ASHRAF", Img = "", Address = "giza" }
        };

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void AddStudent(Student student)
        {
            student.Id = students.Max(s => s.Id) + 1;
            students.Add(student);
        }
    }
}
