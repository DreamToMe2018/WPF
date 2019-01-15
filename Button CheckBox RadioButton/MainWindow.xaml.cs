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

namespace Button_CheckBox_RadioButton
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test1.Content = "ESC Successful";
        }

        private void test2_Click(object sender, RoutedEventArgs e)
        {
            test2.Content = "Enter Successful";
        }

        private void test3_Click(object sender, RoutedEventArgs e)
        {
            test3.Content = "不要碰我";
        }
    }
}
