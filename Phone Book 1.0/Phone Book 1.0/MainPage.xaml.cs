using Windows.ApplicationModel.Contacts;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Phone_Book_1._0
{

    public sealed partial class MainPage : Page
    {
        //Constructor
        public MainPage()
        {
            this.InitializeComponent();

            this.Contacts.ItemsSource = App.Contacts;
        }
        //Button Click Event Handler 
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddPage));
        }

        // Navigation Event Handler
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Contact)
            {
                App.Contacts.Add(e.Parameter as Contact);
            }
        }
    }
}
