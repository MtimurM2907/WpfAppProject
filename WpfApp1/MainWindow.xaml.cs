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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;
        private List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            numbers.Add(counter);
            ListView.Items.Add(counter);
            counter++;
        }
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItem != null) 
            {
                var selectedItem = ListView.SelectedItem;
                numbers.Remove((int)selectedItem);
                ListView.Items.Remove(selectedItem);
            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            counter = 0;
            numbers.Clear();
            ListView.Items.Clear();
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
