using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAddressBook.Window
{
    /// <summary>
    /// RegisterWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class RegisterWindow : System.Windows.Window
    {
        public System.Windows.Window MenuWindow { get; private set; }

        public RegisterWindow(System.Windows.Window window)
        {
            InitializeComponent();
            this.MenuWindow = window;
        }
    }
}
