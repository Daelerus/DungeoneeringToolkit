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
//using System.Windows.Forms.FolderBrwoserDialog;

namespace Dungeoneering_Toolkit.FunctionWindows
{
    /// <summary>
    /// Interaction logic for Publish.xaml
    /// </summary>
    public partial class Publish : Window
    {
        public Publish()
        {
            InitializeComponent();
        }

        private void cmdPublishCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmdPublishPublish_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmdPublishFilepath_Click(object sender, RoutedEventArgs e)
        {
            //var dialog = new System.Windows.Forms.FolderBrowserDialog();
            //System.Windows.Forms.DialogResult result = dialog.ShowDialog();
        }
    }
}
