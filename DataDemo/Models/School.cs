namespace DataDemo.Models
{
    class School
    {
        private List<string> course;
        private List<string> major;
        private List<string> campus;
        private List<string> student;

        public List<string> Course
        {
            get { return course; }
            set { course = value; }
        }

        public List<string> Major
        {
            get { return major; }
            set { major = value; }
        }

        public List<string> Campus
        {
            get { return campus; }
            set { campus = value; }
        }

        public List<string> Student
        {
            get { return student; }
            set { student = value; }
        }
    }
}
