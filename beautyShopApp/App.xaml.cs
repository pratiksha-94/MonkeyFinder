using beautyShopApp.Views;

namespace beautyShopApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomeView());
    }
}
