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
            string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Rob011235\\source\\repos\\DataDemo\\DataDemo\\SchoolDB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Campus", conn);
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
    }
}
