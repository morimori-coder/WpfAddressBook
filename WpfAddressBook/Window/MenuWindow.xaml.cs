using WpfAddressBook.Window;

namespace WpfAddressBook
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MenuWindow : System.Windows.Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void ClickSearchWindowBotton(object sender, System.Windows.RoutedEventArgs e)
        {
            var searchWindow = new SerchWindow(this);
            searchWindow.Show();
            this.IsEnabled = false;
        }

        private void ClickRegisterWindowBotton(object sender, System.Windows.RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow(this);
            registerWindow.Show();
            this.IsEnabled = false;
        }
    }
}
