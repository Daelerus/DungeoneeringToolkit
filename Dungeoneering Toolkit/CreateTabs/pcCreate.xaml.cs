using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using Dungeoneering_Toolkit;

namespace Dungeoneering_Toolkit.CreateTabs
{
    /// <summary>
    /// Interaktionslogik für pcCreate.xaml
    /// </summary>
    public partial class pcCreate : UserControl
    {
        int pcProfMod = 0;
        int pcStrMod, pcDexMod, pcConMod, pcIntMod, pcWisMod, pcChaMod = 0;
       // ObservableCollection<pcEquipmentItem> pcEquipment = new ObservableCollection<pcEquipmentItem>();

        public pcCreate(MainWindow.interfaceMode x)
        {
            InitializeComponent();
            
           // PcEquipmentTable.ItemsSource = pcEquipment;
            foreach (Object o in stPanelMain.Children)
            {
                if (o is CheckBox)
                {
                    (o as CheckBox).Checked += (sender, e) => { updatePc(false, true); };
                    (o as CheckBox).Unchecked += (sender, e) => { updatePc(false, false); };
                }
                if (o is TextBox)
                {
                    (o as TextBox).TextChanged += (sender, e) => { updatePc(true); };
                }
                if (o is ComboBox)
                {
                    (o as ComboBox).SelectionChanged += (sender, e) => { updatePc(false); };
                }
            }
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

        private void cmdPcItemEquipmentAdd_Click(object sender, RoutedEventArgs e)
        {
            List<pcEquipmentItem> items = new List<pcEquipmentItem>();
            this.PcEquipmentTable.Items.Add(items);
            
            //pcEquipment.Add(new pcEquipmentItem());
            //PcEquipmentTable.Height += 25;
        }
        private void cmdPcLanguagesAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Language> items = new List<Language>();
            this.PcLanguageTable.Items.Add(items);
        }
        private void cmdPcProficiencyAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Proficiency> items = new List<Proficiency>();
            this.PcProficienciesTable.Items.Add(items);
        }
        private void cmdPcAttackAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Attacks> items = new List<Attacks>();
            this.PcAttackTable.Items.Add(items);
        }


        private void cmdPcFeatTraitAdd_Click(object sender, RoutedEventArgs e)
        {
            List<FeatsTraits> items = new List<FeatsTraits>();
            this.PcFeatTraitTable.Items.Add(items);
        }
        private void cmdPcRelationshipAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Relationship> items = new List<Relationship>();
            this.PcRelationshipTable.Items.Add(items);
        }
        private void updatePc(bool isTextBox, bool chkChecked = false)
        {
            if (txtPcLevel.Text == string.Empty)
                txtPcLevel.Text = "0";
            for (int i = 0; i < txtPcLevel.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcLevel.Text[i]))
                {
                    txtPcLevel.Text = txtPcLevel.Text.Remove(i, 1);
                }

            }
            int pcLevel = Convert.ToInt32(txtPcLevel.Text);

            switch (pcLevel)
            {
                case 1: { pcProfMod = 2; break; }
                case 2: { pcProfMod = 2; break; }
                case 3: { pcProfMod = 2; break; }
                case 4: { pcProfMod = 2; break; }
                case 5: { pcProfMod = 3; break; }
                case 6: { pcProfMod = 3; break; }
                case 7: { pcProfMod = 3; break; }
                case 8: { pcProfMod = 3; break; }
                case 9: { pcProfMod = 4; break; }
                case 10: { pcProfMod = 4; break; }
                case 11: { pcProfMod = 4; break; }
                case 12: { pcProfMod = 4; break; }
                case 13: { pcProfMod = 5; break; }
                case 14: { pcProfMod = 5; break; }
                case 15: { pcProfMod = 5; break; }
                case 16: { pcProfMod = 5; break; }
                case 17: { pcProfMod = 6; break; }
                case 18: { pcProfMod = 6; break; }
                case 19: { pcProfMod = 6; break; }
                case 20: { pcProfMod = 6; break; }
            }
            if (pcLevel > 20)
                txtPcLevel.Text = txtPcLevel.Text.Remove(txtPcLevel.Text.Length - 1, 1);
            txbPcProficiencyBonus.Text = "Proficiencybonus = " + pcProfMod;

            if (txtPcStrength.Text == string.Empty)
                return;
            for (int i = 0; i < txtPcStrength.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcStrength.Text[i]))
                {
                    txtPcStrength.Text = txtPcStrength.Text.Remove(i, 1);
                }

            }
            int pcStrength = Convert.ToInt32(txtPcStrength.Text);


            switch (pcStrength)
            {
                case 1: { pcStrMod = -5; break; }
                case 2: { pcStrMod = -4; break; }
                case 3: { pcStrMod = -4; break; }
                case 4: { pcStrMod = -3; break; }
                case 5: { pcStrMod = -3; break; }
                case 6: { pcStrMod = -2; break; }
                case 7: { pcStrMod = -2; break; }
                case 8: { pcStrMod = -1; break; }
                case 9: { pcStrMod = -1; break; }
                case 10: { pcStrMod = 0; break; }
                case 11: { pcStrMod = 0; break; }
                case 12: { pcStrMod = 1; break; }
                case 13: { pcStrMod = 1; break; }
                case 14: { pcStrMod = 2; break; }
                case 15: { pcStrMod = 2; break; }
                case 16: { pcStrMod = 3; break; }
                case 17: { pcStrMod = 3; break; }
                case 18: { pcStrMod = 4; break; }
                case 19: { pcStrMod = 4; break; }
                case 20: { pcStrMod = 5; break; }
            }
            if (pcStrength > 20)
                txtPcStrength.Text = txtPcStrength.Text.Remove(txtPcStrength.Text.Length - 1, 1);
            txbPcStrMod.Text = Convert.ToString(pcStrMod);


            if (chkPcSTRProf.IsChecked == true)
            {
                txbPcStrProfMod.Text = Convert.ToString(pcProfMod + pcStrMod);
            }

            else
            {
                txbPcStrProfMod.Text = Convert.ToString(pcStrMod);
            }

            if (txtPcDexterity.Text == string.Empty)
                return;
            for (int i = 0; i < txtPcDexterity.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcDexterity.Text[i]))
                {
                    txtPcDexterity.Text = txtPcDexterity.Text.Remove(i, 1);
                }

            }
            int pcDexterity = Convert.ToInt32(txtPcDexterity.Text);


            switch (pcDexterity)
            {
                case 1: { pcDexMod = -5; break; }
                case 2: { pcDexMod = -4; break; }
                case 3: { pcDexMod = -4; break; }
                case 4: { pcDexMod = -3; break; }
                case 5: { pcDexMod = -3; break; }
                case 6: { pcDexMod = -2; break; }
                case 7: { pcDexMod = -2; break; }
                case 8: { pcDexMod = -1; break; }
                case 9: { pcDexMod = -1; break; }
                case 10: { pcDexMod = 0; break; }
                case 11: { pcDexMod = 0; break; }
                case 12: { pcDexMod = 1; break; }
                case 13: { pcDexMod = 1; break; }
                case 14: { pcDexMod = 2; break; }
                case 15: { pcDexMod = 2; break; }
                case 16: { pcDexMod = 3; break; }
                case 17: { pcDexMod = 3; break; }
                case 18: { pcDexMod = 4; break; }
                case 19: { pcDexMod = 4; break; }
                case 20: { pcDexMod = 5; break; }
            }
            if (pcDexterity > 20)
                txtPcDexterity.Text = txtPcDexterity.Text.Remove(txtPcDexterity.Text.Length - 1, 1);
            txbPcDexMod.Text = Convert.ToString(pcDexMod);


            if (chkPcDEXProf.IsChecked == true)
            {
                txbPcDexProfMod.Text = Convert.ToString(pcProfMod + pcDexMod);
            }

            else
            {
                txbPcDexProfMod.Text = Convert.ToString(pcDexMod);
            }

            if (txtPcConstitution.Text == string.Empty)
                return;
            for (int i = 0; i < txtPcConstitution.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcConstitution.Text[i]))
                {
                    txtPcConstitution.Text = txtPcConstitution.Text.Remove(i, 1);
                }

            }
            int pcConstitution = Convert.ToInt32(txtPcConstitution.Text);


            switch (pcConstitution)
            {
                case 1: { pcConMod = -5; break; }
                case 2: { pcConMod = -4; break; }
                case 3: { pcConMod = -4; break; }
                case 4: { pcConMod = -3; break; }
                case 5: { pcConMod = -3; break; }
                case 6: { pcConMod = -2; break; }
                case 7: { pcConMod = -2; break; }
                case 8: { pcConMod = -1; break; }
                case 9: { pcConMod = -1; break; }
                case 10: { pcConMod = 0; break; }
                case 11: { pcConMod = 0; break; }
                case 12: { pcConMod = 1; break; }
                case 13: { pcConMod = 1; break; }
                case 14: { pcConMod = 2; break; }
                case 15: { pcConMod = 2; break; }
                case 16: { pcConMod = 3; break; }
                case 17: { pcConMod = 3; break; }
                case 18: { pcConMod = 4; break; }
                case 19: { pcConMod = 4; break; }
                case 20: { pcConMod = 5; break; }
            }
            if (pcConstitution > 20)
                txtPcConstitution.Text = txtPcConstitution.Text.Remove(txtPcConstitution.Text.Length - 1, 1);
            txbPcConMod.Text = Convert.ToString(pcConMod);


            if (chkPcCONProf.IsChecked == true)
            {
                txbPcConProfMod.Text = Convert.ToString(pcProfMod + pcConMod);
            }

            else
            {
                txbPcConProfMod.Text = Convert.ToString(pcConMod);
            }

            if (txtPcIntelligence.Text == string.Empty)
                return;
            for (int i = 0; i < txtPcIntelligence.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcIntelligence.Text[i]))
                {
                    txtPcIntelligence.Text = txtPcIntelligence.Text.Remove(i, 1);
                }

            }
            int pcIntelligence = Convert.ToInt32(txtPcIntelligence.Text);


            switch (pcIntelligence)
            {
                case 1: { pcIntMod = -5; break; }
                case 2: { pcIntMod = -4; break; }
                case 3: { pcIntMod = -4; break; }
                case 4: { pcIntMod = -3; break; }
                case 5: { pcIntMod = -3; break; }
                case 6: { pcIntMod = -2; break; }
                case 7: { pcIntMod = -2; break; }
                case 8: { pcIntMod = -1; break; }
                case 9: { pcIntMod = -1; break; }
                case 10: { pcIntMod = 0; break; }
                case 11: { pcIntMod = 0; break; }
                case 12: { pcIntMod = 1; break; }
                case 13: { pcIntMod = 1; break; }
                case 14: { pcIntMod = 2; break; }
                case 15: { pcIntMod = 2; break; }
                case 16: { pcIntMod = 3; break; }
                case 17: { pcIntMod = 3; break; }
                case 18: { pcIntMod = 4; break; }
                case 19: { pcIntMod = 4; break; }
                case 20: { pcIntMod = 5; break; }
            }
            if (pcIntelligence > 20)
                txtPcIntelligence.Text = txtPcIntelligence.Text.Remove(txtPcIntelligence.Text.Length - 1, 1);
            txbPcIntMod.Text = Convert.ToString(pcIntMod);


            if (chkPcINTProf.IsChecked == true)
            {
                txbPcIntProfMod.Text = Convert.ToString(pcProfMod + pcIntMod);
            }

            else
            {
                txbPcIntProfMod.Text = Convert.ToString(pcIntMod);
            }

            if (txtPcWisdom.Text == string.Empty)
                return;
            for (int i = 0; i < txtPcWisdom.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcWisdom.Text[i]))
                {
                    txtPcWisdom.Text = txtPcWisdom.Text.Remove(i, 1);
                }

            }
            int pcWisdom = Convert.ToInt32(txtPcWisdom.Text);


            switch (pcWisdom)
            {
                case 1: { pcWisMod = -5; break; }
                case 2: { pcWisMod = -4; break; }
                case 3: { pcWisMod = -4; break; }
                case 4: { pcWisMod = -3; break; }
                case 5: { pcWisMod = -3; break; }
                case 6: { pcWisMod = -2; break; }
                case 7: { pcWisMod = -2; break; }
                case 8: { pcWisMod = -1; break; }
                case 9: { pcWisMod = -1; break; }
                case 10: { pcWisMod = 0; break; }
                case 11: { pcWisMod = 0; break; }
                case 12: { pcWisMod = 1; break; }
                case 13: { pcWisMod = 1; break; }
                case 14: { pcWisMod = 2; break; }
                case 15: { pcWisMod = 2; break; }
                case 16: { pcWisMod = 3; break; }
                case 17: { pcWisMod = 3; break; }
                case 18: { pcWisMod = 4; break; }
                case 19: { pcWisMod = 4; break; }
                case 20: { pcWisMod = 5; break; }
            }
            if (pcWisdom > 20)
                txtPcWisdom.Text = txtPcWisdom.Text.Remove(txtPcWisdom.Text.Length - 1, 1);
            txbPcWisMod.Text = Convert.ToString(pcWisMod);


            if (chkPcWISProf.IsChecked == true)
            {
                txbPcWisProfMod.Text = Convert.ToString(pcProfMod + pcWisMod);
            }

            else
            {
                txbPcWisProfMod.Text = Convert.ToString(pcWisMod);
            }

            if (txtPcCharisma.Text == string.Empty)
                return;
            for (int i = 0; i < txtPcCharisma.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPcCharisma.Text[i]))
                {
                    txtPcCharisma.Text = txtPcCharisma.Text.Remove(i, 1);
                }

            }
            int pcCharisma = Convert.ToInt32(txtPcCharisma.Text);


            switch (pcCharisma)
            {
                case 1: { pcChaMod = -5; break; }
                case 2: { pcChaMod = -4; break; }
                case 3: { pcChaMod = -4; break; }
                case 4: { pcChaMod = -3; break; }
                case 5: { pcChaMod = -3; break; }
                case 6: { pcChaMod = -2; break; }
                case 7: { pcChaMod = -2; break; }
                case 8: { pcChaMod = -1; break; }
                case 9: { pcChaMod = -1; break; }
                case 10: { pcChaMod = 0; break; }
                case 11: { pcChaMod = 0; break; }
                case 12: { pcChaMod = 1; break; }
                case 13: { pcChaMod = 1; break; }
                case 14: { pcChaMod = 2; break; }
                case 15: { pcChaMod = 2; break; }
                case 16: { pcChaMod = 3; break; }
                case 17: { pcChaMod = 3; break; }
                case 18: { pcChaMod = 4; break; }
                case 19: { pcChaMod = 4; break; }
                case 20: { pcChaMod = 5; break; }
            }
            if (pcCharisma > 20)
                txtPcCharisma.Text = txtPcCharisma.Text.Remove(txtPcCharisma.Text.Length - 1, 1);
            txbPcChaMod.Text = Convert.ToString(pcChaMod);


            if (chkPcCHAProf.IsChecked == true)
            {
                txbPcChaProfMod.Text = Convert.ToString(pcProfMod + pcChaMod);
            }

            else
            {
                txbPcChaProfMod.Text = Convert.ToString(pcChaMod);
            }

            skillUpdate(chkPcAcrobaticsProf, txbPcAcrobaticsProfMod, pcDexMod);
            skillUpdate(chkPcAnimalHandlingProf, txbPcAnimalHandlingProfMod, pcWisMod);
            skillUpdate(chkPcArcanaProf, txbPcArcanaProfMod, pcIntMod);
            skillUpdate(chkPcAthleticsProf, txbPcAthleticsProfMod, pcStrMod);
            skillUpdate(chkPcDeceptionProf, txbPcDeceptionProfMod, pcChaMod);
            skillUpdate(chkPcHistoryProf, txbPcHistoryProfMod, pcIntMod);
            skillUpdate(chkPcInsightProf, txbPcInsightProfMod, pcIntMod);
            skillUpdate(chkPcIntimidationProf, txbPcIntimidationProfMod, pcChaMod);
            skillUpdate(chkPcInvestigationProf, txbPcInvestigationProfMod, pcIntMod);
            skillUpdate(chkPcMedicineProf, txbPcMedicineProfMod, pcWisMod);
            skillUpdate(chkPcNatureProf, txbPcNatureProfMod, pcIntMod);
            skillUpdate(chkPcPerceptionProf, txbPcPerceptionProfMod, pcWisMod);
            skillUpdate(chkPcPerformanceProf, txbPcPerformanceProfMod, pcChaMod);
            skillUpdate(chkPcPersuasionProf, txbPcPersuasionProfMod, pcChaMod);
            skillUpdate(chkPcReligionProf, txbPcReligionProfMod, pcIntMod);
            skillUpdate(chkPcSleightOfHandProf, txbPcSleightOfHandProfMod, pcDexMod);
            skillUpdate(chkPcStealthProf, txbPcStealthProfMod, pcDexMod);
            skillUpdate(chkPcSurvivalProf, txbPcSurvivalProfMod, pcWisMod);

            if (cbxPcArmortype.Text == "Armortype")
            {
                txbPcAC.Text = Convert.ToString((8 + pcDexMod));
            }
            else
            {
                switch (cbxPcArmortype.Text)
                {
                    case "No Armor": txbPcAC.Text = Convert.ToString((8 + pcDexMod));break;
                    case "Padded Armor":txbPcAC.Text = Convert.ToString((11 + pcDexMod)); break;
                    case "Leather Armor":txbPcAC.Text = Convert.ToString((11 + pcDexMod));break;
                    case "Studded Leather Armor":txbPcAC.Text = Convert.ToString(12 + pcDexMod);break;
                    case "Hide Armor":if (pcDexMod > 2) { int i = 2; txbPcAC.Text = Convert.ToString((12 + i)); } else { txbPcAC.Text = Convert.ToString(12 + pcDexMod); }break;
                    case "Chain Shirt": if (pcDexMod > 2) { int i = 2; txbPcAC.Text = Convert.ToString((13 + i)); } else { txbPcAC.Text = Convert.ToString(13 + pcDexMod); } break;
                    case "Scale Mail": if (pcDexMod > 2) { int i = 2; txbPcAC.Text = Convert.ToString((14 + i)); } else { txbPcAC.Text = Convert.ToString(14 + pcDexMod); } break;
                    case "Breastplate": if (pcDexMod > 2) { int i = 2; txbPcAC.Text = Convert.ToString((14 + i)); } else { txbPcAC.Text = Convert.ToString(14 + pcDexMod); }break;
                    case "Half Plate": if (pcDexMod > 2) { int i = 2; txbPcAC.Text = Convert.ToString((15 + i)); } else { txbPcAC.Text = Convert.ToString(15 + pcDexMod); } break;
                    case "Ring Mail": txbPcAC.Text = "14";break;
                    case "Chain Mail": txbPcAC.Text = "16";break;
                    case "Splint Armor": txbPcAC.Text = "17";break;
                    case "Plate Armor": txbPcAC.Text = "18";break;
                }
            }
            //"if (cbxArmorenchantmentlevel.Text != "0")
            if (cbxArmorenchantmentlevel.ToolTip as String != "0")
            {
                switch (cbxArmorenchantmentlevel.Text)
                {
                    case "+1": txbPcAC.Text = Convert.ToString(Convert.ToInt32(txbPcAC.Text) + 1); break;
                    case "+2": txbPcAC.Text = Convert.ToString(Convert.ToInt32(txbPcAC.Text) + 2); break;
                    case "+3": txbPcAC.Text = Convert.ToString(Convert.ToInt32(txbPcAC.Text) + 3); break;
                    case "+4": txbPcAC.Text = Convert.ToString(Convert.ToInt32(txbPcAC.Text) + 4); break;
                    case "+5": txbPcAC.Text = Convert.ToString(Convert.ToInt32(txbPcAC.Text) + 5); break;
                }
            }
            if (cbxPcShield.Text!="")
            {
                txbPcAC.Text = Convert.ToString(Convert.ToInt32(txbPcAC.Text)+2);
            }
            txbPcPassivePerception.Text = Convert.ToString(10 + pcWisMod);
            txbPcInitMod.Text = Convert.ToString(pcDexMod);

            
        }

        private void skillUpdate(CheckBox name ,TextBlock ProfMod, int AbilityMod)
        {

            if (name.IsChecked == true)
            {
                ProfMod.Text = "   "+Convert.ToString(pcProfMod + AbilityMod);
            }

            else
            {
                ProfMod.Text = "   "+Convert.ToString(AbilityMod);
            }

        }

    }
    public class pcEquipmentItem
    {
        //public string ItemName { get; set; }
        //public string ItemWeight { get; set;}
        //public bool Magical { get; set;}
        //public ComboBoxItem Carrytype { get; set; }
    }
    public class Language
    {
        public string Name { get; set; }
        public string Spoken { get; set; }
        public string Written { get; set; }
    }
    public class Proficiency
    {
        public string Name { get; set; }
        public string Proficiencybonus { get; set; }
        public string Attribute { get; set; }
    }
    public class Attacks
    {
        public string Name { get; set; }
        public string Attack { get; set; }
        public string Damage { get; set; }
        public string Range { get; set; }
        public string Ammo { get; set; }
        public string Used { get; set; }
    }
    public class FeatsTraits
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Shortdescription { get; set; }
    }
    public class Relationship
    {
        public string Name { get; set; }
        public string Is { get; set; }
        public string Since { get; set; }
        public string Reasoning { get; set; }
        public string Attributes { get; set; }
    }
    public class EditBox : Control
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(object), typeof(EditBox), new FrameworkPropertyMetadata(null));

        public static DependencyProperty IsEditingProperty = DependencyProperty.Register("IsEditing", typeof(bool), typeof(EditBox), new FrameworkPropertyMetadata(false));
    }
}
