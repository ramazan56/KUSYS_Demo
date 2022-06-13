using KUSYS_Demo.Domain;

namespace KUSYS_Demo.Persistence
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<List<Student>> GetAllWithCourseAsycn();
        Task AddAsync(Student student);
        void Update(int studentId);
        void Update(Student student);
        void Delete(int id);

        int SaveChanges();
    }
}
