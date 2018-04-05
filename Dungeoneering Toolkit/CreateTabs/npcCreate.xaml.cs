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

namespace Dungeoneering_Toolkit.CreateTabs
{
    /// <summary>
    /// Interaktionslogik für npcCreate.xaml
    /// </summary>
    public partial class npcCreate : UserControl
    {
        public npcCreate(MainWindow.interfaceMode x)
        {
            InitializeComponent();
            switch (x)
            {
                case MainWindow.interfaceMode.DnD5thEdition:
                    {
                        //DnD35.Visibility = Visibility.Collapsed;
                        break;
                    }
                case MainWindow.interfaceMode.DnD35Edition:
                    {
                        break;
                    }
                case MainWindow.interfaceMode.Pathfinder:
                    {
                        break;
                    }
            }
        }

        private void cmdNpcItemEquipmentAdd_Click(object sender, RoutedEventArgs e)
        {
            List<NPCItem> items = new List<NPCItem>();
            this.NpcEquipmentTable.Items.Add(items);
        }
        private void cmdNpcLanguagesAdd_Click(object sender, RoutedEventArgs e)
        {
            List<NPCLanguage> items = new List<NPCLanguage>();
            this.NpcLanguageTable.Items.Add(items);
        }
        private void cmdNpcProficiencyAdd_Click(object sender, RoutedEventArgs e)
        {
            List<NPCProficiency> items = new List<NPCProficiency>();
            this.NpcProficienciesTable.Items.Add(items);
        }
        private void cmdNpcAttackAdd_Click(object sender, RoutedEventArgs e)
        {
            List<NPCAttacks> items = new List<NPCAttacks>();
            this.NpcAttackTable.Items.Add(items);
        }
        private void cmdNpcFeatTraitAdd_Click(object sender, RoutedEventArgs e)
        {
            List<NPCFeatsTraits> items = new List<NPCFeatsTraits>();
            this.NpcFeatTraitTable.Items.Add(items);
        }
        private void cmdNpcRelationshipAdd_Click(object sender, RoutedEventArgs e)
        {
            List<NPCRelationship> items = new List<NPCRelationship>();
            this.NpcRelationshipTable.Items.Add(items);
        }
    }
    public class NPCItem
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Magical { get; set; }
        public string Carrytype { get; set; }
    }
    public class NPCLanguage
    {
        public string Name { get; set; }
        public string Spoken { get; set; }
        public string Written { get; set; }
    }
    public class NPCProficiency
    {
        public string Name { get; set; }
        public string Proficiencybonus { get; set; }
        public string Attribute { get; set; }
    }
    public class NPCAttacks
    {
        public string Name { get; set; }
        public string Attack { get; set; }
        public string Damage { get; set; }
        public string Range { get; set; }
        public string Ammo { get; set; }
        public string Used { get; set; }
    }
    public class NPCFeatsTraits
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Shortdescription { get; set; }
    }
    public class NPCRelationship
    {
        public string Name { get; set; }
        public string Is { get; set; }
        public string Since { get; set; }
        public string Reasoning { get; set; }
        public string Attributes { get; set; }
    }
}
