using KUSYS_Demo.Domain;
using Microsoft.EntityFrameworkCore;

namespace KUSYS_Demo.Persistence
{
    public class StudentRepository:IStudentRepository
    {
        private readonly KUSYSDbContext _context;

        public StudentRepository(KUSYSDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllAsync() => await _context.Set<Student>().ToListAsync();

        public async Task<List<Student>> GetAllWithCourseAsycn() => await _context.Set<Student>().Include(x=> x.Course).ToListAsync();

        public async Task AddAsync(Student student) => await _context.Set<Student>().AddAsync(student);

        public void Update(Student student) => _context.Entry(student).State = EntityState.Modified;

        public void Delete(int id)
        {
            var student = _context.Set<Student>().Find(id);
            _context.Set<Student>().Remove(student);

        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(int studentId)
        {
            var student = _context.Set<Student>().Find(studentId);
            _context.Set<Student>().Update(student);
        }
    }
}
