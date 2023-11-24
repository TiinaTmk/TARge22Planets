namespace MauiPlanets.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
		{
			return;
		}

		var parentAnimation = new Animation();
		//Planet Animation
	}
}