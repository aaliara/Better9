
using System;
using Microsoft.Maui.Controls;
namespace Better9.Pages;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}


        // Här kan du lägga till koden för att utföra eventuella initialiseringar
        // t.ex. ladda data eller utföra nätverksanrop
        protected override async void OnAppearing()
        {
            base.OnAppearing();

        // Simulera en kort fördröjning för att visa LoadingPage (ta bort detta i din riktiga kod)
        await System.Threading.Tasks.Task.Delay(3000); // Fördröj i 3 sekunder

        // När allt är klart, navigera användaren till den faktiska huvudsidan
        await Shell.Current.GoToAsync("//MainPage");
        }
    }
