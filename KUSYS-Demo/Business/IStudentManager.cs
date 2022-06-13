using KUSYS_Demo.Domain;

namespace KUSYS_Demo.Business
{
    public interface IStudentManager
    {
        Task<List<Student>> GetAllAsync();
        public bool DeleteStudent(int StudentId);

        public bool UpdateStudent(Student student);

        public bool AddStudent(Student student);
    }
}
