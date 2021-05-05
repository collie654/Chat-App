using Chat_App.Core.ViewModel;
using System.Windows;


namespace Chat_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ApplicationViewModel ApplicationViewModel => new ApplicationViewModel();

        public MainWindow()
        {
            InitializeComponent();

            // Setting the Data context of the program.
            DataContext = new WindowViewModel(this);
        }
    }
}
