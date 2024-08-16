// Controllers/StudentController.cs
using Microsoft.AspNetCore.Mvc;
using StudentMvcApp.Data;
using StudentMvcApp.Models;

namespace StudentMvcApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly MockStudentData _mockStudentData;

        public StudentController()
        {
            _mockStudentData = new MockStudentData();
        }

        public IActionResult GetAllStudent()
        {
            var students = _mockStudentData.GetAllStudents();
            return View(students);
        }

        public IActionResult StudentById(int id)
        {
            var student = _mockStudentData.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _mockStudentData.AddStudent(student);
                return RedirectToAction(nameof(GetAllStudent));
            }
            return View(student);
        }
    }
}
