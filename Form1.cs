using System.Windows.Forms.Integration;

namespace WinFormsAppSetHighDpiModeBug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var elementHost = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = new UserControl1()
            };
            this.Controls.Add(elementHost);
        }
    }
}