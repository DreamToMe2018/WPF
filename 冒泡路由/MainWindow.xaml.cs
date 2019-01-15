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

namespace 冒泡路由
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

        private int eventCounter = 0;
        private void SomethingClicked(object sender, MouseButtonEventArgs e)
        {
            // sender.ToString() e.Source e.OriginalSource控制項
            eventCounter++;
            string message = "#" + eventCounter.ToString() + ":\r\n" + "Sender: " + sender.ToString() + "\r\n" + "Source: " + e.Source + "\r\n"
                + "Orignal Source: " + e.OriginalSource;
            lstMessages.Items.Add(message);
            // e.Handled 只執行第一個 
            e.Handled = (bool)chkHandle.IsChecked;
        }

        private void cmdClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
