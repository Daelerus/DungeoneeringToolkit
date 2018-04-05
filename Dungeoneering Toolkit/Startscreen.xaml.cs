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
    /// Interaktionslogik für Startscreen.xaml
    /// </summary>
    public partial class Startscreen : Window
    {
        public Startscreen()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmdConfirm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.interfaceMode rulesystem=0;
            switch (Rulesystems.Text)
            {
                case "D&D 5e":
                    {
                        rulesystem = MainWindow.interfaceMode.DnD5thEdition;
                        break;
                    }
                case "D&D 3.5":
                    {
                        rulesystem = MainWindow.interfaceMode.DnD35Edition;
                        break;
                    }
                case "Patfinder":
                    {
                        rulesystem = MainWindow.interfaceMode.Pathfinder;
                        break;
                    }
            }
            MainWindow newMainWindow = new MainWindow(rulesystem);
            newMainWindow.Show();
            this.Close();
        }
    }
}
