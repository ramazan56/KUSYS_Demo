namespace KUSYS_Demo.Domain
{
    public class Student
    {
        public Student()
        {

        }
        public Student(int studentId, string courseId, string firstName, string lastName, DateTime birthDate)
        {
          
            CourseId = courseId;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            StudentId=studentId;    
        }

        public int StudentId { get; set; }
        public string CourseId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //Relationship
        public Course Course { get; set; }
    }
}
