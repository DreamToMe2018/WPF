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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 鍵盤按鍵事件
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            string message = "Event: " + e.RoutedEvent + " " + " Key: " + e.Key;
            lstMessages.Items.Add(message);
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            string message = "Event: " + e.RoutedEvent + " " + " Text: " + e.Text;
            lstMessages.Items.Add(message);
        }
    }
}
