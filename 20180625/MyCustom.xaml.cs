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

namespace _20180625
{
    /// <summary>
    /// MyCustom.xaml 的互動邏輯
    /// </summary>
    public partial class MyCustom : Window
    {
        public MyCustom()
        {
            InitializeComponent();
        }

        private void MyCustomControl_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("It is the custom routed event of your custom control");
        }
    }
}
