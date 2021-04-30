using System.Windows;


namespace Chat_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Setting the Data context of the program.
            this.DataContext = new WindowViewModel(this);
        }
    }
}
