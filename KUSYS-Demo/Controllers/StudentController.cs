using Microsoft.AspNetCore.Mvc;
using KUSYS_Demo.Business;
using KUSYS_Demo.Domain;
namespace KUSYS_Demo.Controllers
{
    public class StudentController : Controller
    {
        private IStudentManager _studentManager;

        //Constructor
        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        //listing student information on the page
        public async Task<IActionResult> StudentList()
        {
            List<Student> student = new();
            student = await _studentManager.GetAllAsync();
            return View(student);
        }

        //deleting students by incoming id
        [HttpDelete]
        public JsonResult StudentDelete(int studentId)
        {
            bool result = _studentManager.DeleteStudent(studentId);
            return Json(result);
        }

        //student update based on incoming information
        [HttpPut]
        public JsonResult StudentUpdate(Student dataupdate,int studentId)
        {
            dataupdate.StudentId = studentId;
            bool result = _studentManager.UpdateStudent(dataupdate);
            return Json(result);
        }
        //Adding students based on incoming information
        [HttpPost]
        public JsonResult StudentAdd(Student studentAdd)
        {
            bool result = _studentManager.AddStudent(studentAdd);
            return Json(result);
           
        }
    }
}
