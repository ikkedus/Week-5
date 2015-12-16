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

namespace Opdracht_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] RndGetallen { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            int[] getallen = new int[20];
            var rnd = new Random();
            for (int index = 0; index < getallen.Length; index++)
            {
                getallen[index] = rnd.Next(150);
            }
            vooraf.Content = TableBuilder(getallen);
            RndGetallen = getallen;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int vergelijkgetal = int.Parse(textBox.Text);
            for (int i = 0; i < RndGetallen.Length; i++)
            {
                RndGetallen[i] += (RndGetallen[i] < vergelijkgetal) ? -5 : 10;
            }
            achteraf.Content = TableBuilder(RndGetallen);
            button.IsEnabled = false;
        }

        private string TableBuilder(int[] getallen)
        {
            var sb = new StringBuilder();
            int i = 0;
            foreach (var getal in getallen)
            {
                sb.AppendLine(string.Format("element {0} = {1}", i.ToString("00"), getal));
                i++;
            }

            return sb.ToString();
        }
    }
}
