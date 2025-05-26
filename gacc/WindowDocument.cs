using System.Windows.Forms;

namespace gacc
{
    public partial class WindowDocument : Form
    {
        public WindowDocument(string HTML)
        {
            InitializeComponent();
            this.webBrowser.DocumentText = HTML;
        }
    }
}