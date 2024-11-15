using DataDemo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDemo.Data
{
    public class DataManager
    {
        

        public List<Campus> GetCampuses()
        {
            using SqlConnection conn = new SqlConnection(Settings.ConnStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Campus", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Campus> campuses = new List<Campus>();

            while (reader.Read())
            {
                Campus campus = new Campus();
                campus.Id = reader.GetInt32(0);
                campus.Name = reader.GetString(1);
                campuses.Add(campus);
            }
            return campuses;
        }

        public List<Major> GetMajors()
        {
            using SqlConnection conn = new SqlConnection(Settings.ConnStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Major", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Major> majors = new List<Major>();

            while (reader.Read())
            {
                Major major = new Major();
                major.Id = reader.GetInt32(0);
                major.Title = reader.GetString(1);
                majors.Add(major);
            }
            return majors;
        }

        public List<Course> GetCourses()
        {
            using SqlConnection conn = new SqlConnection(Settings.ConnStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Course> courses = new List<Course>();

            while (reader.Read())
            {
                Course course = new Course();
                course.Id = reader.GetInt32(0);
                course.Name = reader.GetString(1);
                courses.Add(course);
            }
            return courses;
        }
    }
}
