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
        private ProfileManager manageTab;
        public List<Profile> ProfileList
        {
            get => manageTab.Profiles;
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            manageTab = new ProfileManager(profile_selector_groupbox, profile_name_label, profile_name_textbox);
        }



        private void manage_tabitem_Loaded(object sender, RoutedEventArgs e)
        {
            manageTab.EndManagement();
        }

        private void profiles_combobox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            manageTab.SelectProfile(profiles_combobox.SelectedIndex);
        }


        private void save_profile_button_Click(object sender, RoutedEventArgs e)
        {
            manageTab.SetName(profile_name_textbox.Text);

            manageTab.EndManagement();
        }
    }
}
