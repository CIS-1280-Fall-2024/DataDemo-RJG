using DataDemo.Data;
using DataDemo.Models;

namespace DataDemo.Pages;

public partial class CampusesPage : ContentPage
{
    List<Campus> campuses;

    public CampusesPage()
	{
		InitializeComponent();
        //Get campuses
        DataManager dataManager = new DataManager();
        campuses = dataManager.GetCampuses();
        CampusesListView.ItemsSource = campuses;
    }

    private void AddCampusButton_Clicked(object sender, EventArgs e)
    {

        DataManager dataManager = new DataManager();
        Campus campus = new Campus();
        campus.Name = CampusEntry.Text;
        dataManager.AddCampus(campus);
        campuses.Add(campus);
        CampusesListView.ItemsSource = null;
        CampusesListView.ItemsSource = campuses;
    }
}