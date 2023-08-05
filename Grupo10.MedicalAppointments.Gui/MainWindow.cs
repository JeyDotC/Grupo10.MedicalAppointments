using Grupo10.MedicalAppointments.Gui.Views;

namespace Grupo10.MedicalAppointments.Gui
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            AppSetup.Setup(this);
        }
    }
}