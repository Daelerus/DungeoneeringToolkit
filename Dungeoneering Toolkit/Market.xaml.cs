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

namespace Dungeoneering_Toolkit
{
    /// <summary>
    /// Interaktionslogik für Market.xaml
    /// </summary>
    public partial class Market : Window
    {
        public Market()
        {
            InitializeComponent();
        }
        private void cmdMarketClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmdMarketFilter_Click(object sender, RoutedEventArgs e)
        {
            skpMarketFilterOption.Visibility = Visibility.Visible;
        }

        private void cmdFilterOptionApply_Click(object sender, RoutedEventArgs e)
        {
            skpMarketFilterOption.Visibility = Visibility.Hidden;
        }
    }
}
