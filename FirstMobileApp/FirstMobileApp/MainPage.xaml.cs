using FirstMobileApp;
using Xamarin.Forms;

namespace FirstMobileApp
{
    public partial class MainPage : ContentPage
    {
        ChatPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new ChatPageViewModel();
            this.BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Connect();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            await viewModel.Disconnect();
        }
    }
}