
using Microsoft.Data.SqlClient;

namespace Better9.Pages;

public partial class SignupPage : ContentPage
{
    public string connString = "";
	public SignupPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void OnSignupClicked(object sender, EventArgs args)
	{
        //string connString = "Data Source=(localhost)\\LocalDB;Initial Catalog=UserAccounts;Integrated Security=True";
        //SqlConnection sQlConnection = new(connString);
        //await sQlConnection.OpenAsync();
        //string query = "select * from UserMetaData";
        //SqlCommand cmd = new SqlCommand(query, sQlConnection);
        //SqlDataReader rdr = await cmd.ExecuteReaderAsync();
        //while (rdr.Read())
        //{
        //    string output = "output" + rdr.GetValue(0) + " " + rdr.GetValue(1) + " " + rdr.GetValue(2) + " " + rdr.GetValue(3);
        //    await Console.Out.WriteLineAsync(output);
        //}


        await Shell.Current.GoToAsync("LoginPage");
	}

    // new code 
    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
    //}
}