using KUSYS_Demo.Domain;
using KUSYS_Demo.Persistence;

namespace KUSYS_Demo.Business
{
    public class StudentManager:IStudentManager
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public bool AddStudent(Student student)
        {
            _studentRepository.AddAsync(student);
            if (_studentRepository.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteStudent(int StudentId)
        {
             _studentRepository.Delete(StudentId);
            if (_studentRepository.SaveChanges()>0)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllWithCourseAsycn();
        }

        public bool UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
            if (_studentRepository.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}
