using Windows.UI.Xaml.Controls;

namespace Phone_Book_1._0
{
    public sealed partial class AddPage : Page
    {
        //Constructor
        public AddPage()
        {
            this.InitializeComponent();
        }
        //Button Click Event Handler 
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) 
        {
            var contact = new Contact
                (
                picture:this.Picture.Text,
                name:this.Name.Text,
                phone:this.Phone.Text
                );
            this.Frame.Navigate(typeof(MainPage), contact);
        }
    }
}
