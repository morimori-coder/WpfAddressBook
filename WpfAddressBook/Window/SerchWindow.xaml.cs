using System.ComponentModel;
using System.Windows;

namespace WpfAddressBook.Window
{
    /// <summary>
    /// SerchWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class SerchWindow : System.Windows.Window
    {
        public System.Windows.Window MenuWindow { get; private set; }

        public SerchWindow(System.Windows.Window window)
        {
            InitializeComponent();
            this.MenuWindow = window;
        }

        private void SerchWindow_Loaded(object sender, RoutedEventArgs e) 
        {
        }

        private void WindowClosing(object sender, CancelEventArgs e)
        {
            if (MessageBoxResult.Yes != MessageBox.Show("画面を閉じます。よろしいですか？",
                "確認", MessageBoxButton.YesNo, MessageBoxImage.Information))
            {
                e.Cancel = true;                
                return;
            }
            this.MenuWindow.IsEnabled = true;
        }
    }
}
