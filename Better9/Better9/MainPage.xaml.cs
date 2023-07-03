using Microsoft.Maui.Controls.PlatformConfiguration;

namespace Better9;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginPage");
    }

    private async void OnSignupClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SignupPage");
    }
}

