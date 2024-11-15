using DataDemo.Data;
using DataDemo.Models;

namespace DataDemo
{
    public partial class MainPage : ContentPage
    {
        List<Major> majors;
        List<Course> courses;

        public MainPage()
        {
            InitializeComponent();
            //Get campuses
            DataManager dataManager = new DataManager();
            majors = dataManager.GetMajors();
            courses = dataManager.GetCourses();
            MajorsListView.ItemsSource = majors;
            CoursesListView.ItemsSource = courses;
        }
    }
}
