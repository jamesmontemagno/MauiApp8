namespace MauiApp8;

public partial class MainPage2 : ContentPage
{
	public MainPage2()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(MyTabbedPage));
    }
}