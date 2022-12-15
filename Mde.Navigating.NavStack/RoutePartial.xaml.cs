namespace Mde.Navigating.NavStack;

public partial class RoutePartial : ContentView
{
    //constructor, called when instance is created in memory
	public RoutePartial()
	{
		InitializeComponent();

        this.Loaded += RoutePartial_Loaded;
    }

    //destructor, called when instance is removed from memory
    ~RoutePartial()
    {
        this.Loaded -= RoutePartial_Loaded;
    }

    //loaded event hander, called when object is added to the visual tree
    private void RoutePartial_Loaded(object sender, EventArgs e)
    {
        lblRoute.Text = Shell.Current.CurrentState.Location.ToString();
        navStackView.ItemsSource = Navigation.NavigationStack.Select(page => page?.GetType().Name ?? "[null]");
        
    }

}