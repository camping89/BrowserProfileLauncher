using System.Drawing;
using System.Windows.Forms;

namespace BrowserProfileLauncher.Winform.Renderers
{
    public class CustomToolStripItemRenderer : ToolStripProfessionalRenderer
    {
        public CustomToolStripItemRenderer() : base(new Colors())
        {

        }
        private class Colors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                // when the menu is selected
                get { return Color.Black; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Black; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Black; }
            }
        }
    }
}
