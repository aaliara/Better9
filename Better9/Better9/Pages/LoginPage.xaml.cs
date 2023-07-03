namespace Better9.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }

    private async void OnLoginClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("GameOptionsPage");
	}


    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
    //}
}