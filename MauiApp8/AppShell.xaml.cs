namespace MauiApp8;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MyTabbedPage), typeof(MyTabbedPage));
	}
}
