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

namespace Opdracht_7
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int[] dobbelsteen = new int[6];
            var rnd = new Random();
            for (int i = 0; i < 6000; i++)
            {
                dobbelsteen[rnd.Next(0, 6)]++;
            }
            var sb = new StringBuilder();
            for (int i = 0; i < dobbelsteen.Length; i++)
            {
                sb.AppendLine((i + 1) + "is " + dobbelsteen[i] + " keer gegooid");
            }
            label.Content = sb.ToString();
        }
    }
}
