using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace StardewModManager.Profiles
{
    public class ProfileManager
    {
        public int ProfileIndex { get; set; } = 0;

        public List<Profile> Profiles { get; set; } = new List<Profile>()
        {
            new Profile("Profile 1"),
            new Profile("Profile 2"),
            new Profile("Profile 3")
        };

        private GroupBox profileSelectorGroupbox;

        private Label profileNameLabel;
        private TextBox profileNameTextbox;


        public ProfileManager(GroupBox profileSelectorGroupbox, Label profileNameLabel, TextBox profileNameTextbox)
        {
            this.profileSelectorGroupbox = profileSelectorGroupbox;

            this.profileNameLabel = profileNameLabel;
            this.profileNameTextbox = profileNameTextbox;
        }


        public void SetName(string name)
        {
            Profiles[ProfileIndex].Name = name;
        }

        public void SelectProfile(int index)
        {
            ProfileIndex = index;

            profileSelectorGroupbox.Visibility = Visibility.Hidden;

            profileNameLabel.Visibility = Visibility.Visible;
            profileNameTextbox.Visibility = Visibility.Visible;

            PopulateUI();
        }

        public void EndManagement()
        {
            profileSelectorGroupbox.Visibility = Visibility.Visible;

            profileNameLabel.Visibility = Visibility.Hidden;
            profileNameTextbox.Visibility = Visibility.Hidden;

            PopulateUI();
        }

        public void PopulateUI()
        {
            profileNameTextbox.Text = Profiles[ProfileIndex].Name;
        }
    }
}
