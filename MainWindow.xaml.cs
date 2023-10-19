using RelogioDigital.Dados;
using System.Windows;

namespace RelogioDigital
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new Relogio ();
            //DataContext = new Data ();
            DataContext = new RelogioData() ;
        }

        private void MovWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(e.LeftButton == System.Windows.Input.MouseButtonState.Pressed) {
                DragMove();
            }
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
