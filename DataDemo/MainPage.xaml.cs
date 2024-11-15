using DataDemo.Data;
using DataDemo.Models;

namespace DataDemo
{
    public partial class MainPage : ContentPage
    {
        List<Campus> campuses;
        List<Major> majors;
        List<Course> courses;

        public MainPage()
        {
            InitializeComponent();
            //Get campuses
            DataManager dataManager = new DataManager();
            campuses = dataManager.GetCampuses();
            majors = dataManager.GetMajors();
            courses = dataManager.GetCourses();
            CampusesListView.ItemsSource = campuses;
            MajorsListView.ItemsSource = majors;
            CoursesListView.ItemsSource = courses;
        }
    }
}
