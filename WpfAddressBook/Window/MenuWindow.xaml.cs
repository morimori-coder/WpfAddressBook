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

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var searchWindow = new SerchWindow();
            searchWindow.Show();
            this.IsEnabled = false;
        }
    }
}
