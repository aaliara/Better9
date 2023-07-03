using Better9.Pages;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Xaml;

namespace Better9
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Skapa en instans av LoadingPage och sätt den som huvudpage
            MainPage = new LoadingPage();

            // När appen startar, kör en fördröjning för att simulera laddningstiden
            _ = LoadMainPageAsync();
        }

        private async Task LoadMainPageAsync()
        {
            // Simulera en kort fördröjning för att visa LoadingPage (ta bort detta i din riktiga kod)
            await Task.Delay(3000); // Fördröj i 3 sekunder

            // När allt är klart, byt ut LoadingPage mot AppShell som huvudpage
            MainPage = new AppShell();
        }
    }
}
