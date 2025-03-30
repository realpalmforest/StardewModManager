using StardewModManager.Profiles;
using System.Collections.Generic;
using System.Windows;

namespace StardewModManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ManageProfile manageTab = new ManageProfile();
        public List<Profile> ProfileList
        {
            get => manageTab.Profiles;
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }



        private void manage_tabitem_Loaded(object sender, RoutedEventArgs e)
        {
            manageTab.ProfileIndex = 0;
            manageTab.PopulateUI(profile_name_textbox, profiles_combobox);
        }

        private void profile_name_textbox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            manageTab.SetName(profile_name_textbox.Text);
            manageTab.PopulateUI(profile_name_textbox, profiles_combobox);
        }

        private void profiles_combobox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            manageTab.ProfileIndex = profiles_combobox.SelectedIndex;
            manageTab.PopulateUI(profile_name_textbox, profiles_combobox);
        }
    }
}
