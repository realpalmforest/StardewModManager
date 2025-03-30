using System.Collections.Generic;
using System.Windows.Controls;

namespace StardewModManager.Profiles
{
    public class ManageProfile
    {
        public int ProfileIndex { get; set; } = 0;

        public List<Profile> Profiles { get; set; } = new List<Profile>()
        {
            new Profile("Profile 1"),
            new Profile("Profile 2"),
            new Profile("Profile 3")
        };


        public void SetName(string name)
        {
            Profiles[ProfileIndex].Name = name;
        }

        public void PopulateUI(TextBox nameTextBox, ComboBox profilesComboBox)
        {
            nameTextBox.Text = Profiles[ProfileIndex].Name;
            profilesComboBox.SelectedIndex = ProfileIndex;
            // profilesComboBox.Text = Profiles[ProfileIndex].Name;
        }
    }
}
