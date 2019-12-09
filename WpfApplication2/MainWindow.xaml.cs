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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dp.SelectedDate = DateTime.Now;
            button.Name = "button";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dp.SelectedDate = dp.SelectedDate.Value.AddDays(1);

            label.Content = "Clicked!";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dp.SelectedDate = dp.SelectedDate.Value.AddDays(-1);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Clicked!";
            if (dp.SelectedDate == DateTime.Now)
                MessageBox.Show("Its a Match");
            else
                MessageBox.Show("No Match");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content = "Clicked!";
        }
    }
}
