using Mde.Navigating.NavStack.Models;

namespace Mde.Navigating.NavStack;

[QueryProperty(nameof(Activity), "activity")]
public partial class ActivityDetailPage : ContentPage
{
    public ActivityDetailPage()
	{
        InitializeComponent();
	}

	private Activity activity;

	public Activity Activity
    {
		get { return activity; }
		set { activity = value; }
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Title = Activity.Name;
        txtName.Text = Activity.Name;
        txtDescription.Text = Activity.Description;
    }

}