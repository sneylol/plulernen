using TodoMauiApp.ViewModel;

namespace TodoMauiApp.View
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _mainPageViewModel;

        public MainPage()
        {
            InitializeComponent();
            _mainPageViewModel = new MainPageViewModel();
            BindingContext = _mainPageViewModel;
        }
    }

}
