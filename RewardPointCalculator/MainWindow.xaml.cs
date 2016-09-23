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
using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RewardPointCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        KeyConverter kc = new KeyConverter();

        public object DEBUG { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            vm.calculatePoints();
        }

        private void booksTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            string key = kc.ConvertToString(e.Key);
            int _;
            Debug.Print(key);
            if (key == "Return")
            {
                vm.calculatePoints();
            } else {
                for (int i = 0; i < booksTxtBox.Text.Length; i++)
                {
                    if (!int.TryParse(booksTxtBox.Text[i].ToString(), out _))
                    {
                        booksTxtBox.Text = booksTxtBox.Text.Remove(i, 1);
                    }
                }
            }
        }
    }
}
