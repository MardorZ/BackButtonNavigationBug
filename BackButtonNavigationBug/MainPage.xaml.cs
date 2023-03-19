namespace BackButtonNavigationBug
{

    public partial class MainPage : ContentPage
    {
        private INavigationService _navigationService;

        public MainPage(MainViewModel viewModel, INavigationService navigationService)
        {
            this.InitializeComponent();
            this.BindingContext = viewModel;
            this._navigationService = navigationService;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await _navigationService.NavigateAsync("DetailPage");
        }
    }
}