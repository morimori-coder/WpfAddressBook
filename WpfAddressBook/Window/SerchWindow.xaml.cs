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

            for (int i = 1; i <= 12; i ++) 
            { this.MonthComboBox.Items.Add(i.ToString()); }

            for (int i = 1; i <= 31; i++) 
            { this.DayComboBox.Items.Add(i.ToString()); }
        }

        private void WindowClosing(object sender, CancelEventArgs e)
        {
            this.MenuWindow.IsEnabled = true;
        }
    }
}
