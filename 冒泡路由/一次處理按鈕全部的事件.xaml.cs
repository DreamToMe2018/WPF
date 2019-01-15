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

namespace 冒泡路由
{
    /// <summary>
    /// 一次處理按鈕全部的事件.xaml 的互動邏輯
    /// </summary>
    public partial class 一次處理按鈕全部的事件 : Window
    {
        public 一次處理按鈕全部的事件()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            a.Content = "1";
            b.Content = "3";
            c.Content = "5";
            d.Content = "7";
        }
    }
}
