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
using Dungeoneering_Toolkit.CreateTabs;
using System.Diagnostics;
using System.Windows.Controls.Primitives;
using Microsoft.Win32;
using System.IO;
using Dungeoneering_Toolkit.FunctionWindows;

namespace Dungeoneering_Toolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public enum interfaceMode
        {
            DnD5thEdition, DnD35Edition, Pathfinder
        }

        private interfaceMode rulesystem;
        public MainWindow(interfaceMode x)
        {
            InitializeComponent();
            dcpRulesPanel.Visibility = Visibility.Hidden;
            rulesystem = x;
        }
        private void cmdPublishFile_Click(object sender, RoutedEventArgs e)
        {
            Publish newPublishWindow = new Publish();
            newPublishWindow.Show();
        }

        private void cmdPcCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem pcNew = new TabItem();
            pcNew.Header = "New PC";
            pcCreate newPcCreate = new pcCreate(rulesystem);
            pcNew.Content = newPcCreate;
            tabControl.Items.Insert(tabControl.Items.Count-1,pcNew);
            tabControl.SelectedItem = pcNew;
        }
        private void cmdNpcCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem npcNew = new TabItem();
            npcNew.Header = "New NPC";
            npcCreate newNpcCreate = new npcCreate(rulesystem);
            npcNew.Content = newNpcCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, npcNew);
            tabControl.SelectedItem = npcNew;
        }
        private void cmdFactionCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem groupNew = new TabItem();
            groupNew.Header = "New Group";
            groupCreate newGroupCreate = new groupCreate();
            groupNew.Content = newGroupCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, groupNew);
            tabControl.SelectedItem = groupNew;
        }
        private void cmdItemCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem itemNew = new TabItem();
            itemNew.Header = "New Item";
            itemCreate newItemCreate = new itemCreate();
            itemNew.Content = newItemCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, itemNew);
            tabControl.SelectedItem = itemNew;
        }
        private void cmdEventCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem eventNew = new TabItem();
            eventNew.Header = "New Event";
            eventCreate newEventCreate = new eventCreate();
            eventNew.Content = newEventCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, eventNew);
            tabControl.SelectedItem = eventNew;
        }
        private void cmdEncounterCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem encounterNew = new TabItem();
            encounterNew.Header = "New Encounter";
            encounterCreate newEncounterCreate = new encounterCreate();
            encounterNew.Content = newEncounterCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, encounterNew);
            tabControl.SelectedItem = encounterNew;
        }
        private void cmdCityCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem cityNew = new TabItem();
            cityNew.Header = "New City";
            cityCreate newCityCreate = new cityCreate();
            cityNew.Content = newCityCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, cityNew);
            tabControl.SelectedItem = cityNew;
        }
        private void cmdDungeonCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem dungeonNew = new TabItem();
            dungeonNew.Header = "New City";
            dungeonCreate newDungeonCreate = new dungeonCreate();
            dungeonNew.Content = newDungeonCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, dungeonNew);
            tabControl.SelectedItem = dungeonNew;
        }

        private void cmdMapCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem mapNew = new TabItem();
            mapNew.Header = "New Map";
            mapCreate newMapCreate = new mapCreate();
            mapNew.Content = newMapCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, mapNew);
            tabControl.SelectedItem = mapNew;
        }
        private void cmdRuleCreate_Click(object sender, RoutedEventArgs e)
        {
            TabItem ruleNew = new TabItem();
            ruleNew.Header = "New Rule";
            ruleCreate newRuleCreate = new ruleCreate();
            ruleNew.Content = newRuleCreate;
            tabControl.Items.Insert(tabControl.Items.Count - 1, ruleNew);
            tabControl.SelectedItem = ruleNew;
        }
        private void cmdLoad_Click(object sender, RoutedEventArgs e)
        {

            TabItem loadNew = new TabItem();
            tabControl.Items.Insert(tabControl.Items.Count - 1, loadNew);
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == true)
            {
                string filename = open.FileName;
                loadNew.Content = filename;
            }

        }
        private void cmdMarketOpen_Click(object sender, RoutedEventArgs e)
        {
            Market newMarketWindow = new Market();
            newMarketWindow.Show();
        }
        private void cmdAboutOpen_Click(object sender, RoutedEventArgs e)
        {
            About newAboutWindow = new About();
            newAboutWindow.Show();
        }
        private void cmdSettingsOpen_Click(object sender, RoutedEventArgs e)
        {
            Settings newSettingsWindow = new Settings();
            newSettingsWindow.Show();
        }
        private void cmdCreationHelp_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.google.com");
        }
        private void cmdTutorialsHelp_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC0k5DPy7Cpa73kodrsG6hOQ");
        }
        private void cmdRulesystemHelp_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        private void cmdEditRule1_Click(object sender, RoutedEventArgs e)
        {
            txtRule1Description.IsReadOnly = false;
            cmdSaveRule1.Visibility = Visibility.Visible;
        }

        private void cmdSaveRule1_Click(object sender, RoutedEventArgs e)
        {
            txtRule1Description.IsReadOnly = true;
            cmdSaveRule1.Visibility = Visibility.Hidden;
        }

        private void cmdRuleShow_Click(object sender, RoutedEventArgs e)
        {
            if (dcpRulesPanel.Visibility == Visibility.Hidden)
                dcpRulesPanel.Visibility = Visibility.Visible;
            else
                dcpRulesPanel.Visibility = Visibility.Hidden;
        }

        private void cmdMessages_Click(object sender, RoutedEventArgs e)
        {
            if (skpMessagesMain.Visibility == Visibility.Hidden)
                skpMessagesMain.Visibility = Visibility.Visible;
            else
                skpMessagesMain.Visibility = Visibility.Hidden;
        }

        private void cmdNotifications_Click(object sender, RoutedEventArgs e)
        {
            if (skpNotificationsMain.Visibility == Visibility.Hidden)
                skpNotificationsMain.Visibility = Visibility.Visible;
            else
                skpNotificationsMain.Visibility = Visibility.Hidden;
        }
    }
}
