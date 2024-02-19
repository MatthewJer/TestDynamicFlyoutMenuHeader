namespace TestDynamicFlyoutMenuHeader
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            if (Shell.Current.FlyoutHeader is StackLayout stackLaylout)
            {
                stackLaylout.Add (new Button {
                    Text = $"Test Button {++buttonCount}"
                });
            }
            Shell.Current.FlyoutIsPresented = true;
        }

        int buttonCount = 1;

    }

}
