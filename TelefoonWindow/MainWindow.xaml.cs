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

namespace TelefoonWindow
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

        public List<Persoon> personen = new List<Persoon>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            personen.Add(new Persoon("anne", "123", "Vrienden", new BitmapImage(new Uri(@"images/anne.jpg", UriKind.Relative))));
            personen.Add(new Persoon("bob", "456", "Vrienden", new BitmapImage(new Uri(@"images/bob.jpg", UriKind.Relative))));
            personen.Add(new Persoon("collega1", "789", "Werk", new BitmapImage(new Uri(@"images/collega1.jpg", UriKind.Relative))));
            personen.Add(new Persoon("collega2", "10", "Werk", new BitmapImage(new Uri(@"images/collega2.jpg", UriKind.Relative))));
            personen.Add(new Persoon("collega3", "11", "Werk", new BitmapImage(new Uri(@"images/collega3.jpg", UriKind.Relative))));
            personen.Add(new Persoon("ed", "12", "Vrienden", new BitmapImage(new Uri(@"images/ed.jpg", UriKind.Relative))));
            personen.Add(new Persoon("grotezus", "13", "Familie", new BitmapImage(new Uri(@"images/grotezus.jpg", UriKind.Relative))));
            personen.Add(new Persoon("kleinzus", "14", "Familie", new BitmapImage(new Uri(@"images/kleinzus.jpg", UriKind.Relative))));
            personen.Add(new Persoon("tantenon", "15", "Familie", new BitmapImage(new Uri(@"images/tantenon.jpg", UriKind.Relative))));
            personen.Add(new Persoon("vader", "16", "Familie", new BitmapImage(new Uri(@"images/vader.jpg", UriKind.Relative))));

            ComboBoxGroep.Items.Add("- alle groepen -");
            ComboBoxGroep.Items.Add("Vrienden");
            ComboBoxGroep.Items.Add("Familie");
            ComboBoxGroep.Items.Add("Werk");
            ComboBoxGroep.SelectedIndex = 0;
        }

        private void ComboBoxGroep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxPersonen.Items.Clear();
            foreach (Persoon persoon in personen)
            {
                if (persoon.Groep == ComboBoxGroep.SelectedItem.ToString() || ComboBoxGroep.SelectedIndex == 0)
                    ListBoxPersonen.Items.Add(persoon);
            }
            ListBoxPersonen.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription())
        }
    }
}
