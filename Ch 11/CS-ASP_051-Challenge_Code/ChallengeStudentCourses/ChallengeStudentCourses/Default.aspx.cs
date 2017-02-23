using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> courses = new List<Course>()
            {
                new Course { CourseId = 1, Name = "Electronics II", Students = new List<Student>() {
                    new Student() { StudentId = 1, Name = "Michael Lu" },
                    new Student() { StudentId = 2, Name = "Mayra Vasquez" },
                    new Student() { StudentId = 3, Name = "Luis Mi" },
                    new Student() { StudentId = 4, Name = "Aidan McLean" } } },
                new Course { CourseId = 2, Name = "Linear Algebra", Students = new List<Student>() {
                    new Student() { StudentId = 1, Name = "Michael Lu" },
                    new Student() { StudentId = 2, Name = "Mayra Vasquez" },
                    new Student() { StudentId = 4, Name = "Aidan McLean" },
                    new Student() { StudentId = 5, Name = "Eloy Hernandez" } } },
                new Course { CourseId = 3, Name = "Basic Semiconductors", Students = new List<Student>() {
                    new Student() { StudentId = 1, Name = "Michael Lu" },
                    new Student() { StudentId = 5, Name = "Eloy Hernandez" },
                    new Student() { StudentId = 6, Name = "Alex Thammasouk" } } }
             };

            foreach (Course course in courses)
            {
                resultLabel.Text += String.Format("<p>Course ID: {0}, Course Name: {1}</p>",
                    course.CourseId,
                    course.Name);
                foreach (Student student in course.Students) 
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;&nbsp;{0} - {1}<br />",
                        student.StudentId,
                        student.Name);
                }
            }
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course() { CourseId = 1, Name = "CMOS Integrated Circuits II" };
            Course course2 = new Course() { CourseId = 2, Name = "Electric/Magnetic Fields" };
            Course course3 = new Course() { CourseId = 3, Name = "Sensors" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 1, new Student { StudentId = 1, Name = "Michael Lu", Courses = new List<Course> {course1, course2} } },
                { 2, new Student { StudentId = 2, Name = "Lillie E", Courses = new List<Course> {course2, course2} } },
                { 3, new Student { StudentId = 3, Name = "Allie Wang", Courses = new List<Course> {course1, course3} } }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<p>{0} - {1}<br/></p>",
                    student.Value.StudentId,
                    student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;&nbsp;Course: {0} {1}<br />", 
                        course.CourseId, 
                        course.Name);
                }

            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student1 = new Student() { StudentId = 1, Name = "Michael Lu"};
            Student student2 = new Student() { StudentId = 2, Name = "Alex Thammasouk" };
            Student student3 = new Student() { StudentId = 3, Name = "Mike Milowski" };

            student1.Enrollments = new List<Enrollment>()
            {
                new Enrollment { Grade = 81, Course = new Course { CourseId = 1, Name = "Operating Systems I" } },
                new Enrollment { Grade = 80, Course = new Course { CourseId = 2, Name = "Physics 213" }},
                new Enrollment { Grade = 92, Course = new Course { CourseId = 3, Name = "Bio 101" } }
            };

            student2.Enrollments = new List<Enrollment>()
            {
                new Enrollment { Grade = 73, Course = new Course { CourseId = 1, Name = "Operating Systems I" } },
                new Enrollment { Grade = 94, Course = new Course { CourseId = 2, Name = "Physics 213" }},
                new Enrollment { Grade = 88, Course = new Course { CourseId = 4, Name = "ECE 443" } }
            };

            student3.Enrollments = new List<Enrollment>()
            {
                new Enrollment { Grade = 78, Course = new Course { CourseId = 4, Name = "ECE 443" } },
                new Enrollment { Grade = 95, Course = new Course { CourseId = 2, Name = "COMM 114" }},
                new Enrollment { Grade = 98, Course = new Course { CourseId = 3, Name = "WR 327" } }
            };

            resultLabel.Text += String.Format("<p><strong>Student Name: {0}</strong></p>", student1.Name);
            foreach (var enrollment in student1.Enrollments)
            {
                resultLabel.Text += String.Format("<p>&nbsp;Course: {0}<br />&nbsp;Grade: {1}</p>", 
                    enrollment.Course.Name, enrollment.Grade );
            }

            resultLabel.Text += String.Format("<p><strong>Student Name: {0}</strong></p>", student2.Name);
            foreach (var enrollment in student2.Enrollments)
            {
                resultLabel.Text += String.Format("<p>&nbsp;Course: {0}<br />&nbsp;Grade: {1}</p>",
                    enrollment.Course.Name, enrollment.Grade);
            }

            resultLabel.Text += String.Format("<p><strong>Student Name: {0}</strong></p>", student3.Name);
            foreach (var enrollment in student3.Enrollments)
            {
                resultLabel.Text += String.Format("<p>&nbsp;Course: {0}<br />&nbsp;Grade: {1}</p>",
                    enrollment.Course.Name, enrollment.Grade);
            }
        }
    }
}