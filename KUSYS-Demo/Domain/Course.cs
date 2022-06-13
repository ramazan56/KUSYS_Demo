namespace KUSYS_Demo.Domain
{
    public class Course
    {
        public Course()
        {

        }

        public Course(string courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public string CourseId { get; set; }
        public string CourseName { get; set; }

        //Relationship
        public List<Student> Students { get; set; }
    }
}
