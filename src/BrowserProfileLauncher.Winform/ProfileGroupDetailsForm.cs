using BrowserProfileLauncher.Application.Models;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class ProfileGroupDetailsForm : Form
    {
        private readonly ProfileGroupModel _profileGroup;
        public ProfileGroupDetailsForm(ProfileGroupModel profileGroup = null)
        {
            InitializeComponent();
            _profileGroup = profileGroup ?? new ProfileGroupModel();
            LoadProfileGroupDetails();
        }

        private void LoadProfileGroupDetails()
        {
            txtGroupName.Text = _profileGroup.GroupName;
        }
    }
}
