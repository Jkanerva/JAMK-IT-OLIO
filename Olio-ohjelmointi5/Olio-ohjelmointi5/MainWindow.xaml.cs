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

namespace Olio_ohjelmointi5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int trucks = 0, cars = 0;

        private void bt_car_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            lb_cars.Content = cars;
        }

        private void bt_trucks_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            lb_trucks.Content = trucks;
        }
    }
}
