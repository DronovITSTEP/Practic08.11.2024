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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practic08._11._2024
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //DoubleAnimation da = new DoubleAnimation();
            //da.From = btn.ActualWidth;
            //da.To = btn.Width + 200;
            //da.Duration = TimeSpan.FromSeconds(2);
            //da.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(5));
            //btn.BeginAnimation(Button.WidthProperty, da);
        }
    }
}
