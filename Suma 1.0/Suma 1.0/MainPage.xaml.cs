using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Suma_1._0
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void OnButtonClicked(object sender, RoutedEventArgs e)
        {
            var A = int.Parse(this.boxA.Text);
            var B = int.Parse(this.boxB.Text);
            var C = A + B;
            this.boxAB.Text = C.ToString();
        }
    }
}
