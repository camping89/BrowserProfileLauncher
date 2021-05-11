using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform
{
    public partial class CustomUserAgentForm : Form
    {
        public CustomUserAgentForm()
        {
            InitializeComponent();
        }

        private void CustomUserAgentForm_Load(object sender, System.EventArgs e)
        {
            var userAgents = new List<string> {string.Empty};
            if (File.Exists("UserAgents.txt"))
            {
                userAgents.AddRange(File.ReadAllLines("UserAgents.txt"));
            }

            int count = 0;
            foreach (var userAgent in userAgents)
            {
                cbUserAgent.Items.Insert(count, userAgent);
                count++;
            }
        }
    }
}
