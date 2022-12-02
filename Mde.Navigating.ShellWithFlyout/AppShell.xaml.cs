namespace Mde.Navigating.ShellWithFlyout
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void Help_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Help", "You want help? Gandalf is on the way!\n\nAs soon as he's done smoking his pipe, anyways.", "OK");
        }
    }
}