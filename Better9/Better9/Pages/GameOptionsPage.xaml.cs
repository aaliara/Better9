using System.Reflection.Metadata;
using Services.Functions;

namespace Better9.Pages;

public partial class GameOptionsPage : ContentPage
{

	public GameOptionsPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
    }

    private async void OnBetter9Clicked(object sender, EventArgs e)
    {
        Shuffler shuffler = new Shuffler();
        await Shell.Current.GoToAsync("Better9Page");
    }

    private async void OnHokmClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sorry", "This game is not implemented yet", "OK");
        //await Shell.Current.GoToAsync("Better9Page");
    }

    private async void OnSibClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sorry", "This game is not implemented yet", "OK");
        //await Shell.Current.GoToAsync("Better9Page");
    }

    private async void OnSkitGubbeClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sorry", "This game is not implemented yet", "OK");
        //await Shell.Current.GoToAsync("Better9Page");
    }

    private async void OnFortuneTellerClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sorry", "This game is not implemented yet", "OK");
        //await Shell.Current.GoToAsync("Better9Page");
    }

    private async void OnFriendsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sorry", "This game is not implemented yet", "OK");
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Sorry", "This game is not implemented yet", "OK");
    }
}