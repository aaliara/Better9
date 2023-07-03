using Better9.Pages;

namespace Better9;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("SignupPage", typeof(SignupPage));
		Routing.RegisterRoute("LoginPage", typeof(LoginPage));
		Routing.RegisterRoute("GameOptionsPage", typeof(GameOptionsPage));
		Routing.RegisterRoute("Better9Page", typeof(Better9Page));
        NavigationPage.SetHasNavigationBar(this, false);
    }
}
