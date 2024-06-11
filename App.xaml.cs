using JPEDRAZAT2.REGISTRONOTAS;

namespace JPEDRAZAT2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NOTAS();
        }
    }
}
