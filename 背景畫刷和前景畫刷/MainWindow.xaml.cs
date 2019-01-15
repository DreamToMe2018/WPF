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

namespace 背景畫刷和前景畫刷
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            // 設定背景顏色
            test1.Background = new SolidColorBrush(Colors.Yellow);
            // 設定系統預設顏色
            test2.Background = new SolidColorBrush(SystemColors.ControlColor);
            test3.Background = SystemColors.ControlBrush;
            // 設定背景顏色
            byte red = 0; byte green = 255; byte blue = 0;
            test4.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}
